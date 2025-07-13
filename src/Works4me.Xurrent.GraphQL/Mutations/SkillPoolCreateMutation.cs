namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new skill pool.
    /// </summary>
    internal sealed class SkillPoolCreateMutation : Mutation<SkillPoolCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkillPoolCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SkillPoolCreateMutation(SkillPoolCreateInput data, SkillPoolQuery query)
            : base("skillPoolCreate", "SkillPoolCreateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "skillPool")))
        {
        }
    }
}
