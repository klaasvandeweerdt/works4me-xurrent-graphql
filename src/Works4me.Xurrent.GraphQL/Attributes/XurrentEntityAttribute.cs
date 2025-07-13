using System;

namespace Works4me.Xurrent.GraphQL.Attributes
{
    /// <summary>
    /// Specifies the GraphQL data type name for an entity class.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    internal sealed class XurrentEntityAttribute : Attribute
    {
        /// <summary>
        /// Gets the GraphQL data type name associated with the decorated entity class.
        /// </summary>
        public string DataTypeName { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentEntityAttribute"/> class.
        /// </summary>
        /// <param name="dataTypeName">The GraphQL data type name for the entity.</param>
        public XurrentEntityAttribute(string dataTypeName)
        {
            DataTypeName = dataTypeName;
        }
    }
}
