using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Extensions;

namespace Works4me.Xurrent.GraphQL.Builders
{
    /// <summary>
    /// Represents a node in the execution tree for a GraphQL query or mutation, including fields, filters, sub-queries, and metadata.
    /// </summary>
    internal sealed class ExecutionNode
    {
        private static readonly ConcurrentDictionary<Type, Dictionary<string, (string name, XurrentEnumAttribute Attribute)>> _enumLookupCache = new();

        /// <summary>
        /// Represents a node in the execution tree for a GraphQL query or mutation, including fields, filters, sub-queries, and metadata.
        /// </summary>
        public string Name { get;  }


        /// <summary>
        /// Gets the CLR data type for this node.
        /// </summary>
        public Type DataType { get; }

        /// <summary>
        /// Gets the GraphQL data type name for this node.
        /// </summary>
        public string DataTypeName { get; }

        /// <summary>
        /// Gets the type used for filtering fields on this node.
        /// </summary>
        public Type FilterType { get; }

        /// <summary>
        /// Gets a value indicating whether this node represents a connection.
        /// </summary>
        public bool IsConnection { get; }


        /// <summary>
        /// Gets the ID used for this node, if specified.
        /// </summary>
        public string? Id { get; }

        /// <summary>
        /// Gets or sets a value indicating whether only the ID field should be selected.
        /// </summary>
        public bool IdOnly { get; set; }

        /// <summary>
        /// Gets the selected view for this node, if any.
        /// </summary>
        public string? SelectedView { get; }

        /// <summary>
        /// Gets the field name used for ordering results, if any.
        /// </summary>
        public string? OrderBy { get;  }

        /// <summary>
        /// Gets the sort order, if any.
        /// </summary>
        public string? SortOrder { get; }

        /// <summary>
        /// Gets the maximum number of items for this node, if applicable.
        /// </summary>
        public int? ItemsPerRequest { get; }

        /// <summary>
        /// Gets the depth of this node within the query tree.
        /// </summary>
        public int Depth { get; }

        /// <summary>
        /// Gets or sets the paging information for this node.
        /// </summary>
        public PageInfo PageInfo { get; set; } = new();

        /// <summary>
        /// Gets the list of fields associated with this node.
        /// </summary>
        public List<ExecutionNodeField> Fields { get; } = new();

        /// <summary>
        /// Gets the list of filters applied to this node.
        /// </summary>
        public List<ExecutionNodeFilter> Filters { get; } = new();

        /// <summary>
        /// Gets the list of custom filters applied to this node.
        /// </summary>
        public List<ExecutionNodeFilter> CustomFilters { get; } = new();

        /// <summary>
        /// Gets the list of nested child queries for this node.
        /// </summary>
        public List<ExecutionNode> Queries { get; } = new();

        /// <summary>
        /// Gets the list of "on-type" child queries (for interfaces and unions).
        /// </summary>
        public List<ExecutionNode> OnTypeQueries { get; } = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionNode"/> class using the provided name, data type, data type name, and depth.
        /// </summary>
        /// <param name="name">The name of the node (field or type name).</param>
        /// <param name="dataType">The CLR data type for this node.</param>
        /// <param name="dataTypeName">The GraphQL data type name for this node.</param>
        /// <param name="depth">The depth of this node within the query tree.</param>
        internal ExecutionNode(string name, Type dataType, string dataTypeName, int depth)
        {
            Name = name;
            DataType = dataType;
            DataTypeName = dataTypeName;
            FilterType = typeof(string);
            Depth = depth;
            Fields = BuildExecutionNodeFields(DataType, null, false);

            foreach (ExecutionNodeField field in Fields.Where(f => f.IsSelected))
            {
                Type? propertyType = field.PropertyInfo.PropertyType;
                XurrentEntityAttribute? xurrentEntity = propertyType.GetCustomAttribute<XurrentEntityAttribute>();

                if (xurrentEntity is null)
                {
                    if (!propertyType.TryGetXurrentEntityCollection(out xurrentEntity, out propertyType))
                        continue;
                }

                if (!Queries.Any(q => q.Name == field.Name))
                    Queries.Add(new ExecutionNode(field.Name, propertyType!, xurrentEntity!.DataTypeName, depth + 1));

                field.IsSelected = false;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionNode"/> class using a query template, default page size, and depth.
        /// </summary>
        /// <param name="template">The query template used to build the execution node.</param>
        /// <param name="defaultItemsPerRequest">The default number of items to request for connection fields.</param>
        /// <param name="depth">The depth of this node within the query tree.</param>
        public ExecutionNode(IQuery template, int defaultItemsPerRequest, int depth)
        {
            if (depth > 0)
            {
                if (template.Filters.Count > 0)
                    throw new XurrentQueryException("Filters can only be applied on root level.");

                if (template.Id is not null)
                    throw new XurrentQueryException("Id filters can only be applied on root level.");

                if (template.SelectedView is not null)
                    throw new XurrentQueryException("Views can only be applied on root level.");
            }

            Name = template.Name;
            DataType = template.DataType;
            DataTypeName = template.DataTypeName;
            FilterType = template.FilterType;
            IsConnection = template.IsConnection;
            Id = template.Id;
            SelectedView = template.SelectedView;
            ItemsPerRequest = template.ItemsPerRequest ?? defaultItemsPerRequest;
            Depth = depth;
            OrderBy = template.OrderBy;
            SortOrder = template.SortOrder;

            Fields = BuildExecutionNodeFields(DataType, template.Fields, template.SelectAll);
            Filters = BuildExecutionQueryFilterFields(template.FilterType, template.Filters);
            Queries = template.Queries.Select(query => new ExecutionNode(query, defaultItemsPerRequest, depth + 1)).ToList();
            OnTypeQueries = template.OnTypeQueries.Select(query => new ExecutionNode(query, defaultItemsPerRequest, Depth + 1)).ToList();
            PageInfo.HasNextPage = template.IsConnection;

            foreach (ExecutionNodeField field in Fields.Where(f => f.IsSelected))
            {
                Type? propertyType = field.PropertyInfo.PropertyType;
                XurrentEntityAttribute? xurrentEntity = propertyType.GetCustomAttribute<XurrentEntityAttribute>();

                if (xurrentEntity is null)
                {
                    if (!propertyType.TryGetXurrentEntityCollection(out xurrentEntity, out propertyType))
                        continue;
                }

                if (!Queries.Any(q => q.Name == field.Name))
                    Queries.Add(new ExecutionNode(field.Name, propertyType!, xurrentEntity!.DataTypeName, depth + 1));

                field.IsSelected = false;
            }
        }

        /// <summary>
        /// Builds the list of fields for the specified type, marking fields as selected or default based on the provided selection and <paramref name="selectAll"/> flag.
        /// </summary>
        /// <param name="type">The CLR type whose fields to inspect.</param>
        /// <param name="selectedFields">A list of field names to select; if null, only default fields will be selected.</param>
        /// <param name="selectAll">True to select all fields; otherwise, false.</param>
        /// <returns>A list of <see cref="ExecutionNodeField"/> describing the fields on the type.</returns>
        private static List<ExecutionNodeField> BuildExecutionNodeFields(Type type, IReadOnlyList<string>? selectedFields, bool selectAll)
        {
            List<ExecutionNodeField> retval = new();

            PropertyInfo[] allProperties = type
                .GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(x => !x.PropertyType.IsInterface || (x.PropertyType.IsGenericType && x.PropertyType.GetGenericTypeDefinition() == typeof(IReadOnlyList<>)))
                .ToArray();

            foreach (PropertyInfo propertyInfo in allProperties)
            {
                XurrentFieldAttribute? xurrentField = propertyInfo.GetCustomAttribute<XurrentFieldAttribute>();
                if (xurrentField?.FieldName is not string fieldName)
                    continue;

                Type propertyType = propertyInfo.PropertyType;
                bool isDefault = xurrentField.IsDefaultQueryProperty;
                bool isSelectedByName = selectedFields?.Contains(fieldName) == true;
                bool IsIdField = fieldName.Equals("id", StringComparison.Ordinal);
                bool isSelectedAll = selectAll && !propertyType.IsNodeCollection();

                retval.Add(new ExecutionNodeField(fieldName, propertyInfo)
                {
                    IsDefault = isDefault,
                    IsSelected = isSelectedByName || IsIdField || isSelectedAll
                });
            }

            if (!selectAll && (selectedFields is null || selectedFields.Count == 0))
            {
                foreach (ExecutionNodeField field in retval)
                    field.IsSelected = field.IsDefault;
            }

            return retval;
        }


        /// <summary>
        /// Builds the list of filters for the specified filter type from the provided filter list.
        /// </summary>
        /// <param name="type">The filter enum type.</param>
        /// <param name="filters">The list of filters to apply.</param>
        /// <returns>A list of <see cref="ExecutionNodeFilter"/> describing the filters for this node.</returns>
        private static List<ExecutionNodeFilter> BuildExecutionQueryFilterFields(Type type, IReadOnlyList<QueryFilter> filters)
        {
            if (filters.Count == 0)
                return new();

            List<ExecutionNodeFilter> retval = new();

            Dictionary<string, (string name, XurrentEnumAttribute Attribute)> enumLookup = _enumLookupCache.GetOrAdd(type, v =>
            {
                Dictionary<string, (string name, XurrentEnumAttribute Attribute)> enumLookup = new();
                FieldInfo[] enumFields = type.GetFields(BindingFlags.Public | BindingFlags.Static);

                foreach (FieldInfo field in enumFields)
                {
                    XurrentEnumAttribute? attribute = field.GetCustomAttribute<XurrentEnumAttribute>();
                    if (attribute is null || attribute.EnumName is null)
                        continue;

                    if (field.GetValue(null) is not Enum enumValue)
                        continue;

                    enumLookup[attribute.EnumName] = (field.Name, attribute);
                }

                return enumLookup;
            });

            foreach (QueryFilter filter in filters)
            {
                if (filter.ValueType == FilterValueType.Custom || filter.ValueType == FilterValueType.Query)
                {
                    retval.Add(new ExecutionNodeFilter(
                        filter.FieldName,
                        filter.FieldName,
                        filter.Operator,
                        filter.Values.ToList(),
                        filter.ValueType,
                        FilterBehavior.Default
                    ));
                }
                else if (enumLookup.TryGetValue(filter.FieldName, out (string name, XurrentEnumAttribute Attribute) entry))
                {
                    retval.Add(new ExecutionNodeFilter(
                        entry.name,
                        filter.FieldName,
                        filter.Operator,
                        filter.Values.ToList(),
                        filter.ValueType,
                        entry.Attribute.FilterBehavior
                    ));
                }
            }

            return retval;
        }
    }
}
