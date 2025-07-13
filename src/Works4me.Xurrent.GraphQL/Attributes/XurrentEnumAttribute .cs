using System;

namespace Works4me.Xurrent.GraphQL.Attributes
{
    /// <summary>
    /// Specifies a custom name for an enum member and optional filter behavior.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    internal sealed class XurrentEnumAttribute : Attribute
    {
        /// <summary>
        /// Gets the custom enum name to use in GraphQL requests.
        /// </summary>
        public string? EnumName { get; }

        /// <summary>
        /// Gets or sets the filter behavior for this enum member.
        /// </summary>
        public FilterBehavior FilterBehavior { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentEnumAttribute"/> class.
        /// </summary>
        /// <param name="enumName">The custom enum name to use for this member; if null, the field name is used.</param>

        public XurrentEnumAttribute(string? enumName)
        {
            EnumName = enumName;
            FilterBehavior = FilterBehavior.None;
        }
    }
}
