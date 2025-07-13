using System;

namespace Works4me.Xurrent.GraphQL.Attributes
{
    /// <summary>
    /// Specifies that a property maps to a field in the Xurrent API and controls its query or mutation behavior.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    internal sealed class XurrentFieldAttribute : Attribute
    {
        /// <summary>
        /// Gets the Xurrent API field name to which this property maps.
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// Gets or sets a value indicating whether this property is included by default in query operations.
        /// </summary>
        public bool IsDefaultQueryProperty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this property is required for mutation operations.
        /// </summary>
        public bool IsRequiredForMutation { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentFieldAttribute"/> class.
        /// </summary>
        /// <param name="fieldName">The name of the field in the Xurrent API schema to which this property maps.</param>
        public XurrentFieldAttribute(string fieldName)
        {
            FieldName = fieldName;
        }
    }
}
