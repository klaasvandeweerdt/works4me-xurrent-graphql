using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on SkillPools.
    /// </summary>
    public enum SkillPoolView
    {
        /// <summary>
        /// Skill Pools.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// All SkillPools which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount
    }
}
