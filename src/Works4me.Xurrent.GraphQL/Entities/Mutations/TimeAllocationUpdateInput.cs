using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/timeallocationupdateinput/">TimeAllocationUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class TimeAllocationUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private TimeAllocationCustomerCategory? _customerCategory;
        private TimeAllocationDescriptionCategory? _descriptionCategory;
        private bool? _disabled;
        private string? _effortClassId;
        private string? _group;
        private string? _name;
        private TimeAllocationServiceCategory? _serviceCategory;
        private Collection<string>? _customerIds;
        private Collection<string>? _serviceIds;
        private Collection<string>? _organizationIds;
        private string _id;

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
        /// Whether a person who spent on the time allocation needs to select a customer organization, and if this is the case, whether this person may only select from the customer organizations linked to the time allocation or is allowed to select any customer organization.
        /// </summary>
        [XurrentField("customerCategory")]
        public TimeAllocationCustomerCategory? CustomerCategory
        {
            get => _customerCategory;
            set => _customerCategory = Set("customerCategory", value);
        }

        /// <summary>
        /// Whether the Description field should be available, and if so, whether it should be required, in the time entries to which the time allocation is related.
        /// </summary>
        [XurrentField("descriptionCategory")]
        public TimeAllocationDescriptionCategory? DescriptionCategory
        {
            get => _descriptionCategory;
            set => _descriptionCategory = Set("descriptionCategory", value);
        }

        /// <summary>
        /// Whether the time allocation may no longer be related to any more organizations.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone registers time on this time allocation.
        /// </summary>
        [XurrentField("effortClassId")]
        public string? EffortClassId
        {
            get => _effortClassId;
            set => _effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// Which group to include the time allocation in.
        /// </summary>
        [XurrentField("group")]
        public string? Group
        {
            get => _group;
            set => _group = Set("group", value);
        }

        /// <summary>
        /// The name of the time allocation.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Whether a Person who spent on the time allocation needs to select a service, and if this is the case, whether this person may only select from the services linked to the time allocation or is allowed to select any service.
        /// </summary>
        [XurrentField("serviceCategory")]
        public TimeAllocationServiceCategory? ServiceCategory
        {
            get => _serviceCategory;
            set => _serviceCategory = Set("serviceCategory", value);
        }

        /// <summary>
        /// Identifiers of the customer organizations of the time allocation.
        /// </summary>
        [XurrentField("customerIds")]
        public Collection<string>? CustomerIds
        {
            get => _customerIds;
            set => _customerIds = Set("customerIds", value);
        }

        /// <summary>
        /// Identifiers of the services of the time allocation.
        /// </summary>
        [XurrentField("serviceIds")]
        public Collection<string>? ServiceIds
        {
            get => _serviceIds;
            set => _serviceIds = Set("serviceIds", value);
        }

        /// <summary>
        /// Identifiers of the organizations of the time allocation.
        /// </summary>
        [XurrentField("organizationIds")]
        public Collection<string>? OrganizationIds
        {
            get => _organizationIds;
            set => _organizationIds = Set("organizationIds", value);
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
        /// Initializes a new instance of the <see cref="TimeAllocationUpdateInput"/> class without providing the required values.
        /// </summary>
        public TimeAllocationUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeAllocationUpdateInput"/> class.
        /// </summary>
        public TimeAllocationUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
