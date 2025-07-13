using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/permissioninput/">PermissionInput</see> in Xurrent.
    /// </summary>
    public sealed class PermissionInput : PropertyChangeSet
    {
        private string _accountId;
        private Collection<PermissionRole>? _roles;

        /// <summary>
        /// Identifier of the account for which the person has permissions.
        /// </summary>
        [XurrentField("accountId")]
        public string AccountId
        {
            get => _accountId;
            set => _accountId = Set("accountId", value);
        }

        /// <summary>
        /// Roles the person has within the account.
        /// </summary>
        [XurrentField("roles")]
        public Collection<PermissionRole>? Roles
        {
            get => _roles;
            set => _roles = Set("roles", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionInput"/> class without providing the required values.
        /// </summary>
        public PermissionInput()
        {
            _accountId = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionInput"/> class.
        /// </summary>
        public PermissionInput(string accountId)
        {
            _accountId = Set("accountId", accountId);
        }
    }
}
