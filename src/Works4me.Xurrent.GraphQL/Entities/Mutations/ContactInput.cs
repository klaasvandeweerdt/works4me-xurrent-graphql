using System;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/contactinput/">ContactInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class ContactInput : PropertyChangeSet
    {
        private string? _id;
        private ContactLabel? _label;
        private ContactProtocol? _protocol;
        private Uri? _uri;
        private bool? _integration;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [XurrentField("id")]
        public string? Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

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
        [XurrentField("label")]
        public ContactLabel? Label
        {
            get => _label;
            set => _label = Set("label", value);
        }

        /// <summary>
        /// The protocol of the contact details.
        /// </summary>
        [XurrentField("protocol")]
        public ContactProtocol? Protocol
        {
            get => _protocol;
            set => _protocol = Set("protocol", value);
        }

        /// <summary>
        /// The telephone number, email address, etc.
        /// </summary>
        [XurrentField("uri")]
        public Uri? Uri
        {
            get => _uri;
            set => _uri = Set("uri", value);
        }

        /// <summary>
        /// Can be set to <c>true</c> using this API or the Import functionality. When checked, the contact is displayed as read-only in the user interface to prevent users from updating it.
        /// </summary>
        [XurrentField("integration")]
        public bool? Integration
        {
            get => _integration;
            set => _integration = Set("integration", value);
        }
    }
}
