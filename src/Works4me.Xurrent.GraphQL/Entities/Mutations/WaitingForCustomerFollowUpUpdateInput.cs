using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/waitingforcustomerfollowupupdateinput/">WaitingForCustomerFollowUpUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class WaitingForCustomerFollowUpUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private bool? _disabled;
        private string? _name;
        private bool? _autoComplete;
        private Collection<WaitingForCustomerRuleInput>? _newWaitingForCustomerRules;
        private string _id;
        private Collection<string>? _waitingForCustomerRulesToDelete;

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
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Whether the waiting for customer follow-up may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// The name of the waiting for customer follow-up.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Auto-complete when the final waiting for customer notification is sent.
        /// </summary>
        [XurrentField("autoComplete")]
        public bool? AutoComplete
        {
            get => _autoComplete;
            set => _autoComplete = Set("autoComplete", value);
        }

        /// <summary>
        /// Rules of this waiting for customer follow-up.
        /// </summary>
        [XurrentField("newWaitingForCustomerRules")]
        public Collection<WaitingForCustomerRuleInput>? NewWaitingForCustomerRules
        {
            get => _newWaitingForCustomerRules;
            set => _newWaitingForCustomerRules = Set("newWaitingForCustomerRules", value);
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
        /// Identifiers of rules to remove from the waiting for customer follow-up.
        /// </summary>
        [XurrentField("waitingForCustomerRulesToDelete")]
        public Collection<string>? WaitingForCustomerRulesToDelete
        {
            get => _waitingForCustomerRulesToDelete;
            set => _waitingForCustomerRulesToDelete = Set("waitingForCustomerRulesToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingForCustomerFollowUpUpdateInput"/> class without providing the required values.
        /// </summary>
        public WaitingForCustomerFollowUpUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingForCustomerFollowUpUpdateInput"/> class.
        /// </summary>
        public WaitingForCustomerFollowUpUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
