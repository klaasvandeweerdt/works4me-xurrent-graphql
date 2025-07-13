using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/skillpoolupdatepayload/">SkillPoolUpdatePayload</see> in Xurrent.
    /// </summary>
    public sealed class SkillPoolUpdatePayload : MutationResultBase
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [XurrentField("skillPool", IsDefaultQueryProperty = true)]
        public SkillPool? SkillPool { get; internal set; }
    }
}
