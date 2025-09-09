using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/waitingforcustomerruleinput/">WaitingForCustomerRuleInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class WaitingForCustomerRuleInput : PropertyChangeSet
    {
        private string? _id;
        private long? _nrOfBusinessDays;

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
        /// Notify the requester after the request has been waiting for a customer for this number of business days.
        /// </summary>
        [XurrentField("nrOfBusinessDays")]
        public long? NrOfBusinessDays
        {
            get => _nrOfBusinessDays;
            set => _nrOfBusinessDays = Set("nrOfBusinessDays", value);
        }
    }
}
