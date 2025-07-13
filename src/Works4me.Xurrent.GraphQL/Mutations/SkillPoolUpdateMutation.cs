namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing skill pool.
    /// </summary>
    internal sealed class SkillPoolUpdateMutation : Mutation<SkillPoolUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkillPoolUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the skill pool mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal SkillPoolUpdateMutation(SkillPoolUpdateInput data, SkillPoolQuery query)
            : base("skillPoolUpdate", "SkillPoolUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "skillPool")))
        {
        }
    }
}
