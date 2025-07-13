using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Extensions;

namespace Works4me.Xurrent.GraphQL.Builders
{
    /// <summary>
    /// Builds and serializes the execution tree for a GraphQL query or mutation, including filters, paging, and selection sets.
    /// </summary>
    internal sealed class ExecutionBuilder
    {
        private readonly ExecutionNode _root;
        private readonly IMutation? _mutation;

        /// <summary>
        /// Initializes a new <see cref="ExecutionBuilder"/> for the specified query and default item limit per request.
        /// </summary>
        /// <param name="query">The root query to execute.</param>
        /// <param name="defaultItemsPerRequest">The default maximum number of items to return per request for connection queries.</param>
        public ExecutionBuilder(IQuery query, int defaultItemsPerRequest)
        {
            _root = new ExecutionNode(query, defaultItemsPerRequest, 0);
        }

        /// <summary>
        /// Initializes a new <see cref="ExecutionBuilder"/> for the specified mutation.
        /// </summary>
        /// <param name="mutation">The mutation to execute.</param>
        public ExecutionBuilder(IMutation mutation)
        {
            _root = new ExecutionNode(mutation.Query, 1, 0);
            _mutation = mutation;
        }

        /// <summary>
        /// Recursively calculates the maximum depth of nested connection fields.
        /// </summary>
        /// <returns>The maximum depth of connection fields found.</returns>
        public int GetMaximumConnectionDepth()
        {
            return GetMaximumConnectionDepth(_root, 0) + 1;
        }

        /// <summary>
        /// Recursively calculates the maximum depth of nested connection fields in the specified execution node tree.
        /// </summary>
        /// <param name="node">The root execution node to evaluate.</param>
        /// <param name="startDepth">The starting depth value.</param>
        /// <returns>The maximum depth of connection fields found in the execution node tree.</returns>
        private static int GetMaximumConnectionDepth(ExecutionNode node, int startDepth)
        {
            int maxDepth = startDepth;
            foreach (ExecutionNode query in node.Queries)
            {
                if (query.IsConnection)
                {
                    int currentDepth = query.Depth;
                    if (currentDepth > maxDepth)
                        maxDepth = currentDepth;
                }

                int childMaxDepth = GetMaximumConnectionDepth(query, maxDepth);
                if (childMaxDepth > maxDepth)
                    maxDepth = childMaxDepth;
            }

            foreach (ExecutionNode onQuery in node.OnTypeQueries)
            {
                int childMaxDepth = GetMaximumConnectionDepth(onQuery, maxDepth);
                if (childMaxDepth > maxDepth)
                    maxDepth = childMaxDepth;
            }

            return maxDepth;
        }


        /// <summary>
        /// Returns the GraphQL query or mutation string for the current execution tree.
        /// </summary>
        /// <returns>A <see cref="string"/> containing the GraphQL query or mutation.</returns>
        public string GetGraphQLQuery()
        {
            StringBuilder builder = new();
            if (_mutation is null)
            {
                builder.Append("query {");
                builder.Append(GetGraphQLQuery(_root, 0, false));
                builder.Append('}');
            }
            else
            {
                builder.Append($"mutation($input: {_mutation.DataTypeName}) ");
                builder.Append($"{{{_mutation.Name}(input: $input) ");
                builder.Append(GetGraphQLQuery(_root, 0, false).Trim());
                builder.Append('}');
            }
            return builder.ToString();
        }

        /// <summary>
        /// Gets the name of the root response object for the query or mutation.
        /// </summary>
        /// <returns>The response object name, or <c>node</c> for single-entity queries.</returns>
        public string GetResponseObjectName()
        {
            return _mutation is not null ? _mutation.Name : (_root.Id is null ? _root.Name : "node");
        }

        /// <summary>
        /// Returns true if the root node represents a paged collection (connection).
        /// </summary>
        /// <returns><c>true</c> if the root node is a connection; otherwise, <c>false</c>.</returns>
        public bool IsResponseCollection()
        {
            return _root.IsConnection && _root.Id is null;
        }

        /// <summary>
        /// Gets the mapping of GraphQL interface names to CLR types from the execution tree.
        /// </summary>
        /// <returns>A <see cref="Dictionary{String, Type}"/> mapping interface names to types.</returns>
        public Dictionary<string, Type> GetInterfaceMappings()
        {
            Dictionary<string, Type> result = new();
            CollectInterfaceMappings(_root, result);
            return result;
        }

        /// <summary>
        /// Recursively collects mappings from interface names to CLR types for all nodes in the execution tree.
        /// </summary>
        /// <param name="node">The execution node to inspect.</param>
        /// <param name="result">The dictionary to populate with mappings.</param>
        private static void CollectInterfaceMappings(ExecutionNode node, Dictionary<string, Type> result)
        {
            foreach (ExecutionNode onTypeNode in node.OnTypeQueries)
                result.TryAdd(onTypeNode.DataTypeName, onTypeNode.DataType);

            foreach (ExecutionNode query in node.Queries)
                CollectInterfaceMappings(query, result);
        }

        /// <summary>
        /// Builds the GraphQL query string for the specified execution node.
        /// </summary>
        /// <param name="node">The execution node to serialize.</param>
        /// <param name="depth">The current depth in the tree.</param>
        /// <param name="returnSelectionOnly">True to return only the selection set (without wrapper fields).</param>
        /// <returns>A <see cref="string"/> representing the GraphQL query for this node.</returns>
        private static string GetGraphQLQuery(ExecutionNode node, int depth, bool returnSelectionOnly)
        {
            IEnumerable<string> selectedFields = node.Fields
                .Where(f => f.IsSelected)
                .Select(f => f.Name);

            if (node.IdOnly)
            {
                IEnumerable<string> idOnlyFields = node.Fields
                    .Where(f => string.Equals(f.Name, "id", StringComparison.Ordinal))
                    .Select(f => f.Name);

                if (idOnlyFields.Any())
                    selectedFields = idOnlyFields;
            }

            string fields = string.Join(" ", selectedFields);
            string children = string.Join(" ", node.Queries.Select(c => GetGraphQLQuery(c, depth + 1, false)));
            string onTypeChilderen = GetOnTypeGraphQLQuery(node.OnTypeQueries, depth + 1);
            string selection = string.Join(" ", new[] { fields, children, onTypeChilderen }.Where(s => !string.IsNullOrEmpty(s)));

            if (returnSelectionOnly)
            {
                return selection;
            }
            else if (node.Id is not null)
            {
                return $"node(id: {JsonSerializer.Serialize(node.Id)}) {{... on {node.DataTypeName} {{{selection}}}}}";
            }
            else if (node.IsConnection)
            {
                string parameters = $"first:{node.ItemsPerRequest}"
                    + (node.PageInfo.EndCursor is string endCursor ? $" after: {JsonSerializer.Serialize(endCursor)}" : "")
                    + (node.SelectedView is string view ? $" view: {view}" : "" )
                    + (node.OrderBy is string orderBy && node.SortOrder is string sortOrder ? $" order: {{field:{orderBy} direction:{sortOrder} }}": "")
                    + (depth == 0 && node.Filters.Count > 0 ? " " + GetFilter(node) : "");

                return $"{node.Name}({parameters}){{nodes{{{selection}}} pageInfo{{endCursor hasNextPage}}}}";
            }
            return $"{node.Name} {{{selection}}}";
        }

        /// <summary>
        /// Builds the "on-type" selection set string for interface and union fields.
        /// </summary>
        /// <param name="onTypeQueries">The list of on-type child queries.</param>
        /// <param name="depth">The current depth in the tree.</param>
        /// <returns>A <see cref="string"/> containing the on-type GraphQL selection set.</returns>
        private static string GetOnTypeGraphQLQuery(List<ExecutionNode> onTypeQueries, int depth)
        {
            if (onTypeQueries.FirstOrDefault() is ExecutionNode node)
            {
                if (node.IsConnection)
                {
                    return $"{node.Name}(first:{node.ItemsPerRequest}) {{nodes {{__typename {string.Join(" ", onTypeQueries.Select(c => $"... on {c.DataTypeName} {{{GetGraphQLQuery(c, depth + 1, true)}}}"))}}}}}";
                }
                else
                {
                    return $"{node.Name} {{__typename {string.Join(" ", onTypeQueries.Select(c => $"... on {c.DataTypeName} {{{GetGraphQLQuery(c, depth + 1, true)}}}"))}}}";
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// Builds the filter clause for the specified execution node, combining all applicable filters.
        /// </summary>
        /// <param name="node">The execution node for which to build the filter clause.</param>
        /// <returns>A <see cref="string"/> representing the GraphQL filter clause, or empty if no filters.</returns>
        private static string GetFilter(ExecutionNode node)
        {
            if (node.Filters is null || node.Filters.Count == 0)
                return string.Empty;

            IEnumerable<string> clauses = node.Filters
                .Select(filter => filter.ValueType switch
                {
                    FilterValueType.String => GetStringFilter(filter),
                    FilterValueType.Integer => GetIntegerFilter(filter),
                    FilterValueType.Boolean => GetBooleanFilter(filter),
                    FilterValueType.DateTime => GetDateTimeFilter(filter),
                    FilterValueType.Custom => GetCustomFilter(filter),
                    FilterValueType.Query => GetQueryFilter(filter),
                    _ => throw new XurrentQueryException($"Unsupported filter type: {filter.ValueType}")
                });

           return $"filter:{{{string.Join(" ", clauses)}}}";
        }

        /// <summary>
        /// Builds a custom filter clause for the given filter.
        /// </summary>
        /// <param name="filter">The custom filter to serialize.</param>
        /// <returns>A <see cref="string"/> representing the custom filter clause.</returns>
        private static string GetCustomFilter(ExecutionNodeFilter filter)
        {
            List<string> serializedValues = SerializeValues(filter).Distinct().ToList();
            string serializedName = JsonSerializer.Serialize(filter.Name);

            switch (filter.Operator)
            {
                case FilterOperator.Equals:
                    return $"customFilters:{{name:{serializedName} values:[{string.Join(",", serializedValues)}]}}";

                case FilterOperator.NotEquals:
                    return $"customFilters:{{name:{serializedName} negate:true values:[{string.Join(",", serializedValues)}]}}";

                case FilterOperator.Present:
                    return $"customFilters:{{name:{serializedName} negate:true values:[null]}}";

                case FilterOperator.Empty:
                    return $"customFilters:{{name:{serializedName} values:[null]}}";

                default:
                    throw new XurrentQueryException(
                        $"Unsupported string filter operator for '{filter.Name}'. Supported operators include " +
                        $"{nameof(FilterOperator.Equals)}, {nameof(FilterOperator.NotEquals)}, " +
                        $"{nameof(FilterOperator.Present)}, and {nameof(FilterOperator.Empty)}.");
            }
        }

        /// <summary>
        /// Builds a query-text filter clause.
        /// </summary>
        /// <param name="filter">The query filter to serialize.</param>
        /// <returns>A <see cref="string"/> representing the query filter clause.</returns>
        private static string GetQueryFilter(ExecutionNodeFilter filter)
        {
            return $"query:{JsonSerializer.Serialize(filter.Values.First())}";
        }

        /// <summary>
        /// Builds a string filter clause for the given filter.
        /// </summary>
        /// <param name="filter">The string filter to serialize.</param>
        /// <returns>A <see cref="string"/> representing the string filter clause.</returns>
        private static string GetStringFilter(ExecutionNodeFilter filter)
        {
            List<string> serializedValues = SerializeValues(filter).Distinct().ToList();

            if (filter.FilterBehavior == FilterBehavior.Simple)
            {
                if (filter.Operator != FilterOperator.Equals || serializedValues.Count != 1)
                {
                    throw new XurrentQueryException(
                        $"Unsupported string filter operator for '{filter.Name}', " +
                        $"use {nameof(FilterOperator.Equals)} with a single value.");
                }
                return $"{filter.FieldName}:{serializedValues[0]}";
            }

            switch (filter.Operator)
            {
                case FilterOperator.Equals:
                    return $"{filter.FieldName}:{{values:[{string.Join(",", serializedValues)}]}}";

                case FilterOperator.NotEquals:
                    return $"{filter.FieldName}:{{negate:true values:[{string.Join(",", serializedValues)}]}}";

                case FilterOperator.Present:
                    return $"{filter.FieldName}:{{negate:true values:[]}}";

                case FilterOperator.Empty:
                    return $"{filter.FieldName}:{{values:[]}}";

                default:
                    throw new XurrentQueryException(
                        $"Unsupported string filter operator for '{filter.Name}'. Supported operators include " +
                        $"{nameof(FilterOperator.Equals)}, {nameof(FilterOperator.NotEquals)}, " +
                        $"{nameof(FilterOperator.Present)}, and {nameof(FilterOperator.Empty)}.");
            }
        }

        /// <summary>
        /// Builds a boolean filter clause for the given filter.
        /// </summary>
        /// <param name="filter">The boolean filter to serialize.</param>
        /// <returns>A <see cref="string"/> representing the boolean filter clause.</returns>
        private static string GetBooleanFilter(ExecutionNodeFilter filter)
        {
            string serializedValue = SerializeValues(filter).First();

            switch (filter.Operator)
            {
                case FilterOperator.Equals:
                    return $"{filter.FieldName}:{serializedValue}";

                case FilterOperator.NotEquals:
                    string inverted = serializedValue == "true" ? "false" : "true";
                    return $"{filter.FieldName}:{inverted}";

                default:
                    throw new XurrentQueryException(
                        $"Unsupported boolean filter operator for '{filter.Name}'. " +
                        $"Supported operators are {nameof(FilterOperator.Equals)} and {nameof(FilterOperator.NotEquals)}.");
            }
        }

        /// <summary>
        /// Builds a date/time filter clause for the given filter.
        /// </summary>
        /// <param name="filter">The date/time filter to serialize.</param>
        /// <returns>A <see cref="string"/> representing the date/time filter clause.</returns>
        private static string GetDateTimeFilter(ExecutionNodeFilter filter)
        {
            if (filter.Operator == FilterOperator.Equals || filter.Operator == FilterOperator.NotEquals)
            {
                return GetStringFilter(filter);
            }

            List<string> serializedValues = SerializeValues(filter);
            int count = serializedValues.Count;

            if (count == 1)
            {
                switch (filter.Operator)
                {
                    case FilterOperator.LessThan:
                        return $"{filter.FieldName}:{{lessThan:{serializedValues[0]}}}";

                    case FilterOperator.LessThanOrEqualsTo:
                        return $"{filter.FieldName}:{{lessThanOrEqualTo:{serializedValues[0]}}}";

                    case FilterOperator.GreaterThan:
                        return $"{filter.FieldName}:{{greaterThan:{serializedValues[0]}}}";

                    case FilterOperator.GreaterThanOrEqualsTo:
                        return $"{filter.FieldName}:{{greaterThanOrEqualTo:{serializedValues[0]}}}";
                }
            }

            if (count == 2)
            {
                switch (filter.Operator)
                {
                    case FilterOperator.GreaterThanAndLessThan:
                        return $"{filter.FieldName}:{{greaterThan:{serializedValues[0]} lessThan:{serializedValues[1]}}}";

                    case FilterOperator.GreaterThanOrEqualToAndLessThanOrEqualTo:
                        return $"{filter.FieldName}:{{greaterThanOrEqualTo:{serializedValues[0]} lessThanOrEqualTo:{serializedValues[1]}}}";
                }
            }

            throw new XurrentQueryException(
                $"Unsupported date time filter operator for '{filter.Name}'. " +
                $"Use {nameof(FilterOperator.Equals)} or {nameof(FilterOperator.NotEquals)} with one or multiple values; " +
                $"use {nameof(FilterOperator.LessThan)}, {nameof(FilterOperator.LessThanOrEqualsTo)}, " +
                $"{nameof(FilterOperator.GreaterThan)}, or {nameof(FilterOperator.GreaterThanOrEqualsTo)} with a single value; " +
                $"and use {nameof(FilterOperator.GreaterThanAndLessThan)} or " +
                $"{nameof(FilterOperator.GreaterThanOrEqualToAndLessThanOrEqualTo)} with two values.");
        }

        /// <summary>
        /// Builds an integer filter clause for the given filter.
        /// </summary>
        /// <param name="filter">The integer filter to serialize.</param>
        /// <returns>A <see cref="string"/> representing the integer filter clause.</returns>
        private static string GetIntegerFilter(ExecutionNodeFilter filter)
        {
            List<string> serializedValues = SerializeValues(filter).ToList();
            int count = serializedValues.Count;

            if (filter.FilterBehavior == FilterBehavior.Simple)
            {
                if (filter.Operator != FilterOperator.Equals || count != 1)
                {
                    throw new XurrentQueryException(
                        $"Unsupported integer filter operator for '{filter.Name}', " +
                        $"use {nameof(FilterOperator.Equals)} with a single value.");
                }

                return $"{filter.FieldName}:{serializedValues[0]}";
            }

            if (filter.Operator == FilterOperator.Equals)
            {
                return $"{filter.FieldName}:{{values:[{string.Join(",", serializedValues)}]}}";
            }

            if (filter.Operator == FilterOperator.NotEquals)
            {
                return $"{filter.FieldName}:{{negate:true values:[{string.Join(",", serializedValues)}]}}";
            }

            if (count == 1)
            {
                string single = serializedValues[0];
                switch (filter.Operator)
                {
                    case FilterOperator.LessThan:
                        return $"{filter.FieldName}:{{lessThan:{single}}}";
                    case FilterOperator.LessThanOrEqualsTo:
                        return $"{filter.FieldName}:{{lessThanOrEqualTo:{single}}}";
                    case FilterOperator.GreaterThan:
                        return $"{filter.FieldName}:{{greaterThan:{single}}}";
                    case FilterOperator.GreaterThanOrEqualsTo:
                        return $"{filter.FieldName}:{{greaterThanOrEqualTo:{single}}}";
                }
            }

            if (count == 2)
            {
                string first = serializedValues[0];
                string second = serializedValues[1];
                switch (filter.Operator)
                {
                    case FilterOperator.GreaterThanAndLessThan:
                        return $"{filter.FieldName}:{{greaterThan:{first} lessThan:{second}}}";
                    case FilterOperator.GreaterThanOrEqualToAndLessThanOrEqualTo:
                        return $"{filter.FieldName}:{{greaterThanOrEqualTo:{first} lessThanOrEqualTo:{second}}}";
                }
            }

            throw new XurrentQueryException(
                $"Unsupported integer filter operator for '{filter.Name}'. " +
                $"Use {nameof(FilterOperator.Equals)} or {nameof(FilterOperator.NotEquals)} with one or multiple values; " +
                $"use {nameof(FilterOperator.LessThan)}, {nameof(FilterOperator.LessThanOrEqualsTo)}, " +
                $"{nameof(FilterOperator.GreaterThan)}, or {nameof(FilterOperator.GreaterThanOrEqualsTo)} with a single value; " +
                $"and use {nameof(FilterOperator.GreaterThanAndLessThan)} or " +
                $"{nameof(FilterOperator.GreaterThanOrEqualToAndLessThanOrEqualTo)} with two values.");
        }

        /// <summary>
        /// Serializes the values for the given filter into strings suitable for inclusion in the query.
        /// </summary>
        /// <param name="filter">The filter whose values to serialize.</param>
        /// <returns>A <see cref="List{String}"/> of serialized values.</returns>
        private static List<string> SerializeValues(ExecutionNodeFilter filter)
        {
            List<string> serializedValues = new();
            bool jsonSerialized = filter.ValueType == FilterValueType.String || filter.ValueType == FilterValueType.DateTime || filter.ValueType == FilterValueType.Custom || filter.ValueType == FilterValueType.Query;

            foreach (string? value in filter.Values)
            {
                if (value is null && filter.FieldName == "id")
                {
                    throw new XurrentQueryException($"All values must be non-null when the field {filter.Name} is specified for filtering.");
                }

                if (jsonSerialized)
                {
                    serializedValues.Add(JsonSerializer.Serialize(value));
                }
                else
                {
                    serializedValues.Add(value ?? "null");
                }
            }
            return serializedValues;
        }

        /// <summary>
        /// Updates the paging cursors of the execution tree based on the provided paged response data.
        /// </summary>
        /// <typeparam name="TEntity">The entity type being paged.</typeparam>
        /// <param name="fieldName">The name of the field to update cursors for.</param>
        /// <param name="data">The paged response data.</param>
        /// <returns>The target depth at which paging should continue, or <c>null</c> if paging is complete.</returns>
        public int? UpdateCursors<TEntity>(string fieldName, PagedResponse<TEntity>? data)
            where TEntity : IDataItem, new()
        {
            if (data is null)
                return null;

            List<ExecutionPageInfo> allPageInfos = new()
            {
                new(fieldName, 0, data.PageInfo.EndCursor, data.PageInfo.HasNextPage)
            };

            foreach (TEntity child in data.Data)
            {
                allPageInfos.AddRange(child.GetPageInfo(1));
            }

            List<ExecutionPageInfo> pending = allPageInfos.Where(pi => pi.HasNextPage).ToList();
            if (pending.Count == 0)
            {
                ClearAll(_root);
                return null;
            }

            int targetDepth = pending.Max(pi => pi.Depth);
            foreach (ExecutionPageInfo? pi in pending.Where(x => x.Depth == targetDepth))
            {
                ExecutionNode? node = TryFindNode(_root, pi.FieldName, pi.Depth);
                if (node is not null)
                {
                    node.PageInfo = new PageInfo
                    {
                        EndCursor = pi.EndCursor,
                        HasNextPage = true
                    };
                }
            }

            MarkIdOnly(_root, targetDepth);

            return targetDepth;
        }

        /// <summary>
        /// Recursively clears all paging information from the execution tree rooted at the specified node.
        /// </summary>
        /// <param name="node">The root execution node.</param>
        private static void ClearAll(ExecutionNode node)
        {
            if (node.IsConnection)
            {
                node.PageInfo = new PageInfo();
            }

            foreach (ExecutionNode child in node.Queries)
            {
                ClearAll(child);
            }
        }

        /// <summary>
        /// Recursively marks nodes as "ID only" at or above the specified target depth.
        /// </summary>
        /// <param name="node">The root execution node.</param>
        /// <param name="targetDepth">The maximum depth at which to mark nodes as "ID only".</param>
        private static void MarkIdOnly(ExecutionNode node, int targetDepth)
        {
            node.IdOnly = node.IsConnection && typeof(INode).IsAssignableFrom(node.DataType) && node.Depth < targetDepth;

            foreach (ExecutionNode child in node.Queries)
            { 
                MarkIdOnly(child, targetDepth); 
            }
        }

        /// <summary>
        /// Attempts to find the execution node matching the given name and depth within the execution tree.
        /// </summary>
        /// <param name="node">The root node to start searching from.</param>
        /// <param name="name">The field name to find.</param>
        /// <param name="depth">The depth at which to find the node.</param>
        /// <returns>The <see cref="ExecutionNode"/> if found; otherwise, <c>null</c>.</returns>
        private static ExecutionNode? TryFindNode(ExecutionNode node, string name, int depth)
        {
            if (node.Depth == depth && node.Name == name)
                return node;

            foreach (ExecutionNode child in node.Queries)
            {
                ExecutionNode? found = TryFindNode(child, name, depth);
                if (found is not null)
                    return found;
            }

            return null;
        }
    }
}
