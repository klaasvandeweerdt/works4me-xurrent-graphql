using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/waitingforcustomerfollowupcreateinput/">WaitingForCustomerFollowUpCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class WaitingForCustomerFollowUpCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private bool? _disabled;
        private bool? _autoComplete;
        private Collection<WaitingForCustomerRuleInput>? _newWaitingForCustomerRules;
        private string _name;

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
        /// The name of the waiting for customer follow-up.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingForCustomerFollowUpCreateInput"/> class without providing the required values.
        /// </summary>
        public WaitingForCustomerFollowUpCreateInput()
        {
            _name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingForCustomerFollowUpCreateInput"/> class.
        /// </summary>
        public WaitingForCustomerFollowUpCreateInput(string name)
        {
            _name = Set("name", name);
        }
    }
}
