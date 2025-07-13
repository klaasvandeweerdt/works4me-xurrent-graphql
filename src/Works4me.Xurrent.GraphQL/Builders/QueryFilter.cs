using System.Collections.Generic;

namespace Works4me.Xurrent.GraphQL.Builders
{
    /// <summary>
    /// Represents a filter applied to a GraphQL query, including the field name, filter operator, filter values, and value type.
    /// </summary>
    internal sealed class QueryFilter
    {
        /// <summary>
        /// Gets the name of the field to filter on.
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// Gets the operator to use for filtering.
        /// </summary>
        public FilterOperator Operator { get; }

        /// <summary>
        /// Gets the values to use for filtering.
        /// </summary>
        public IReadOnlyList<string?> Values { get; }

        /// <summary>
        /// Gets the value type of the filter.
        /// </summary>
        public FilterValueType ValueType { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFilter"/> class.
        /// </summary>
        /// <param name="fieldName">The name of the field to filter on.</param>
        /// <param name="op">The <see cref="FilterOperator"/> to use for filtering.</param>
        /// <param name="values">The values to use for filtering.</param>
        /// <param name="valueType">The type of the filter values.</param>
        public QueryFilter(string fieldName, FilterOperator op, string?[] values, FilterValueType valueType)
        {
            FieldName = fieldName;
            Operator = op;
            Values = values;
            ValueType = valueType;
        }
    }
}
