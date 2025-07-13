using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/slanotificationschemeupdateinput/">SlaNotificationSchemeUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class SlaNotificationSchemeUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private bool? _disabled;
        private string? _name;
        private Collection<SlaNotificationRuleInput>? _newSlaNotificationRules;
        private string _id;
        private Collection<string>? _slaNotificationRulesToDelete;

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
        /// Whether the SLA notification scheme may no longer be related to other records.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// The name of the SLA notification scheme.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Rules of this SLA notification scheme.
        /// </summary>
        [XurrentField("newSlaNotificationRules")]
        public Collection<SlaNotificationRuleInput>? NewSlaNotificationRules
        {
            get => _newSlaNotificationRules;
            set => _newSlaNotificationRules = Set("newSlaNotificationRules", value);
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
        /// Identifiers of rules to remove from the scheme.
        /// </summary>
        [XurrentField("slaNotificationRulesToDelete")]
        public Collection<string>? SlaNotificationRulesToDelete
        {
            get => _slaNotificationRulesToDelete;
            set => _slaNotificationRulesToDelete = Set("slaNotificationRulesToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlaNotificationSchemeUpdateInput"/> class without providing the required values.
        /// </summary>
        public SlaNotificationSchemeUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlaNotificationSchemeUpdateInput"/> class.
        /// </summary>
        public SlaNotificationSchemeUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
