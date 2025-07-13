using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/surveycreatepayload/">SurveyCreatePayload</see> in Xurrent.
    /// </summary>
    public sealed class SurveyCreatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("survey", IsDefaultQueryProperty = true)]
        public Survey? Survey { get; internal set; }
    }
}
