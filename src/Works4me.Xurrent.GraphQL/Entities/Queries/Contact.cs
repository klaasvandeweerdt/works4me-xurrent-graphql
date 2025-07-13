using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/contact/">Contact</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Contact")]
    public sealed class Contact : IDataItem, INode
    {
        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Can be set to <c>true</c> using this API or the Import functionality. When checked, the contact is displayed as read-only in the user interface to prevent users from updating it.
        /// </summary>
        [XurrentField("integration", IsDefaultQueryProperty = true)]
        public bool? Integration { get; internal set; }

        /// <summary>
        /// The Label of the contact details. Valid values are:<br />
        ///   • <c>fax</c>: only for <c>telephone</c>.<br />
        ///   • <c>general</c>: only for organization <c>telephone</c>, <c>email</c> and <c>website</c>.<br />
        ///   • <c>home</c>: only for person <c>telephone</c>.<br />
        ///   • <c>mobile</c>: only for person <c>telephone</c>.<br />
        ///   • <c>personal</c>: only for person <c>email</c> and <c>website</c>.<br />
        ///   • <c>service_desk</c>: only for organization <c>telephone</c>, <c>email</c> and <c>website</c>.<br />
        ///   • <c>service_desk_fax</c>: only for organization <c>telephone</c>.<br />
        ///   • <c>work</c>: only for organization <c>telephone</c>, and for person <c>telephone</c>, <c>email</c> and <c>website</c>.<br />
        /// </summary>
        [XurrentField("label", IsDefaultQueryProperty = true)]
        public ContactLabel? Label { get; internal set; }

        /// <summary>
        /// The protocol of the contact details.
        /// </summary>
        [XurrentField("protocol", IsDefaultQueryProperty = true)]
        public ContactProtocol? Protocol { get; internal set; }

        /// <summary>
        /// The telephone number, email address, etc.
        /// </summary>
        [XurrentField("uri", IsDefaultQueryProperty = true)]
        public Uri? Uri { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return Enumerable.Empty<ExecutionPageInfo>();
        }
    }
}
