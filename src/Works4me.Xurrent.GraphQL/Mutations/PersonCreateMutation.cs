namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Creates a new person.
    /// </summary>
    internal sealed class PersonCreateMutation : Mutation<PersonCreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonCreateMutation"/> class.
        /// </summary>
        /// <param name="data">The input data for the person mutation.</param>
        /// <param name="query">The query specifying which fields to return in the response.</param>
        internal PersonCreateMutation(PersonCreateInput data, PersonQuery? query)
            : base("personCreate", "PersonCreateInput!", data, query is null ? new PersonCreatePayloadQuery() : new PersonCreatePayloadQuery().Select(UpdateQuery(query, "person")))
        {
        }
    }
}
