using System.Reflection;

namespace Works4me.Xurrent.GraphQL.Builders
{
    /// <summary>
    /// Represents a field in a GraphQL execution node, including metadata and selection state.
    /// </summary>
    internal sealed class ExecutionNodeField
    {
        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="PropertyInfo"/> for this field.
        /// </summary>
        public PropertyInfo PropertyInfo { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this field is included by default in query results.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this field is currently selected in the query.
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionNodeField"/> class.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="propertyInfo">The <see cref="PropertyInfo"/> associated with this field.</param>
        internal ExecutionNodeField(string name, PropertyInfo propertyInfo)
        {
            Name = name;
            PropertyInfo = propertyInfo;
        }
    }
}
