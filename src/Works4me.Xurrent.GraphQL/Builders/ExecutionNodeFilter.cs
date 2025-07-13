using System.Collections.Generic;

namespace Works4me.Xurrent.GraphQL.Builders
{
    /// <summary>
    /// Represents a filter to be applied on a field in a GraphQL execution node.
    /// </summary>
    internal sealed class ExecutionNodeFilter
    {
        /// <summary>
        /// Gets the unique filter name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the GraphQL field name being filtered.
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// Gets the operator used for filtering.
        /// </summary>
        public FilterOperator Operator { get; }

        /// <summary>
        /// Gets the values to use for filtering.
        /// </summary>
        public List<string?> Values { get; }

        /// <summary>
        /// Gets the type of value for this filter.
        /// </summary>
        public FilterValueType ValueType { get; }

        /// <summary>
        /// Gets the filter behavior to use for this field.
        /// </summary>
        public FilterBehavior FilterBehavior { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionNodeFilter"/> class.
        /// </summary>
        /// <param name="name">The unique filter name (may be the enum or custom name).</param>
        /// <param name="fieldName">The GraphQL field name being filtered.</param>
        /// <param name="op">The filter operator.</param>
        /// <param name="values">The filter values.</param>
        /// <param name="valueType">The type of value for this filter.</param>
        /// <param name="filterBehavior">The filter behavior to use for this field.</param>
        public ExecutionNodeFilter(string name, string fieldName, FilterOperator op, List<string?> values, FilterValueType valueType, FilterBehavior filterBehavior)
        {
            Name = name;
            FieldName = fieldName;
            Operator = op;
            Values = values;
            ValueType = valueType;
            FilterBehavior = filterBehavior;
        }
    }
}
