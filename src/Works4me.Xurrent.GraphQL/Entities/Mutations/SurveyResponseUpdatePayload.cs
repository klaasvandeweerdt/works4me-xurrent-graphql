using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/surveyresponseupdatepayload/">SurveyResponseUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class SurveyResponseUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("surveyResponse", IsDefaultQueryProperty = true)]
        public SurveyResponse? SurveyResponse { get; internal set; }
    }
}
