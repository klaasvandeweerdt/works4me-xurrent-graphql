using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/requestupdatevisibilityinput/">RequestUpdateVisibilityInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class RequestUpdateVisibilityInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string _id;
        private string? _accountID;
        private bool? _visible;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [XurrentField("clientMutationId")]
        public string? ClientMutationId
        {
            get => _clientMutationId;
            set => _clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// The identifier of the request account.
        /// </summary>
        [XurrentField("accountID")]
        public string? AccountID
        {
            get => _accountID;
            set => _accountID = Set("accountID", value);
        }

        /// <summary>
        /// Indicates whether the request should be visible within the supplied request account.
        /// </summary>
        [XurrentField("visible")]
        public bool? Visible
        {
            get => _visible;
            set => _visible = Set("visible", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestUpdateVisibilityInput"/> class without providing the required values.
        /// </summary>
        public RequestUpdateVisibilityInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestUpdateVisibilityInput"/> class.
        /// </summary>
        public RequestUpdateVisibilityInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
