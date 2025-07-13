namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Updates an existing person.
    /// </summary>
    internal sealed class PersonUpdateMutation : Mutation<PersonUpdateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonUpdateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal PersonUpdateMutation(PersonUpdateInput data, PersonQuery query)
            : base("personUpdate", "PersonUpdateInput!", data, new MutationResponseQuery().Select(UpdateQuery(query, "person")))
        {
        }
    }
}
