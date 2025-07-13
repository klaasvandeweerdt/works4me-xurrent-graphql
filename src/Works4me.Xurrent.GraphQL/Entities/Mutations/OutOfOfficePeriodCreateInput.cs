using System;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/outofofficeperiodcreateinput/">OutOfOfficePeriodCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class OutOfOfficePeriodCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _approvalDelegateId;
        private string? _reason;
        private string? _timeAllocationId;
        private string? _effortClassId;
        private string _personId;
        private DateTime _startAt;
        private DateTime _endAt;

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
        /// Identifier of the person who is selected as the approval delegate for the out of office period.
        /// </summary>
        [XurrentField("approvalDelegateId")]
        public string? ApprovalDelegateId
        {
            get => _approvalDelegateId;
            set => _approvalDelegateId = Set("approvalDelegateId", value);
        }

        /// <summary>
        /// The reason of the out of office period. Required when the description category of the time allocation is required.
        /// </summary>
        [XurrentField("reason")]
        public string? Reason
        {
            get => _reason;
            set => _reason = Set("reason", value);
        }

        /// <summary>
        /// Used to generate time entries for the out of office period. Only the time allocations without service and customer that are linked to the person's organization can be selected. This field is required if at least one time allocation exists that meets those conditions.
        /// </summary>
        [XurrentField("timeAllocationId")]
        public string? TimeAllocationId
        {
            get => _timeAllocationId;
            set => _timeAllocationId = Set("timeAllocationId", value);
        }

        /// <summary>
        /// Used to generate time entries for the out of office period. This field is required if the timesheet settings linked to the person's organization has one or more effort classes.
        /// </summary>
        [XurrentField("effortClassId")]
        public string? EffortClassId
        {
            get => _effortClassId;
            set => _effortClassId = Set("effortClassId", value);
        }

        /// <summary>
        /// Identifier of the person who is out of office.
        /// </summary>
        [XurrentField("personId")]
        public string PersonId
        {
            get => _personId;
            set => _personId = Set("personId", value);
        }

        /// <summary>
        /// Start time of the out of office period.
        /// </summary>
        [XurrentField("startAt")]
        public DateTime StartAt
        {
            get => _startAt;
            set => _startAt = Set("startAt", value);
        }

        /// <summary>
        /// End time of the out of office period.
        /// </summary>
        [XurrentField("endAt")]
        public DateTime EndAt
        {
            get => _endAt;
            set => _endAt = Set("endAt", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfOfficePeriodCreateInput"/> class without providing the required values.
        /// </summary>
        public OutOfOfficePeriodCreateInput()
        {
            _personId = string.Empty;
            _startAt = default;
            _endAt = default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutOfOfficePeriodCreateInput"/> class.
        /// </summary>
        public OutOfOfficePeriodCreateInput(string personId, DateTime startAt, DateTime endAt)
        {
            _personId = Set("personId", personId);
            _startAt = Set("startAt", startAt);
            _endAt = Set("endAt", endAt);
        }
    }
}
