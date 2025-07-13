using System;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Indicates that an interface represents a Xurrent GraphQL interface type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    internal sealed class XurrentInterfaceAttribute : Attribute
    {
    }
}
