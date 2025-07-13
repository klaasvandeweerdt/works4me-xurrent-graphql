using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/outofofficeperioddeletemutationpayload/">OutOfOfficePeriodDeleteMutationPayload</see> in Xurrent.
    /// </summary>
    public sealed class OutOfOfficePeriodDeleteMutationPayload : MutationResultBase
    {
        /// <summary>
        /// <c>true</c> when the record was successfully deleted, <c>false</c> otherwise.
        /// </summary>
        [XurrentField("success", IsDefaultQueryProperty = true)]
        public bool? Success { get; internal set; }
    }
}
