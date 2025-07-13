using System.Collections.Immutable;
using Works4me.Xurrent.GraphQL.Mutations;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represents a GraphQL mutation request and its associated data, query, and metadata.
    /// </summary>
    /// <typeparam name="TEntity">The type of the mutation input data, which must derive from <see cref="PropertyChangeSet"/>.</typeparam>
    internal class Mutation<TEntity> : IMutation
        where TEntity : PropertyChangeSet
    {
        private readonly string _name;
        private readonly string _dataTypeName;
        private readonly TEntity _data;
        private readonly IQuery _query;

        /// <inheritdoc/>
        public string Name
        {
            get => _name;
        }

        /// <inheritdoc/>
        public string DataTypeName
        {
            get => _dataTypeName;
        }

        /// <summary>
        /// Gets the input data for the mutation.
        /// </summary>
        public TEntity Data
        {
            get => _data;
        }

        /// <inheritdoc/>
        public IQuery Query
        {
            get => _query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mutation{TEntity}"/> class.
        /// </summary>
        /// <param name="name">The GraphQL mutation name.</param>
        /// <param name="dataTypeName">The GraphQL mutation input type name.</param>
        /// <param name="data">The mutation input data.</param>
        /// <param name="query">The response query.</param>
        internal Mutation(string name, string dataTypeName, TEntity data, IQuery query)
        {
            _name = name;
            _dataTypeName = dataTypeName;
            _data = data;
            _query = query;
        }

        /// <summary>
        /// Updates the specified query to use the given GraphQL mutation response name and disables connection paging.
        /// </summary>
        /// <param name="query">The query to update.</param>
        /// <param name="name">The GraphQL field name for the response object.</param>
        /// <returns>The updated <see cref="IQuery"/> instance.</returns>
        internal static IQuery UpdateQuery(IQuery query, string name)
        {
            query.Name = name;
            query.IsConnection = false;
            return query;
        }

        /// <summary>
        /// Gets the set of field names affected by this mutation.
        /// </summary>
        /// <returns>An <see cref="ImmutableHashSet{String}"/> containing the names of changed fields.</returns>
        public ImmutableHashSet<string> GetFields()
        {
            return _data.GetFields();
        }
    }
}
