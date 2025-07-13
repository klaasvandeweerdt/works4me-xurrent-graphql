using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ParentServiceInstance"/> query class.
    /// </summary>
    public class ParentServiceInstanceQuery : Query<ParentServiceInstance, ParentServiceInstanceQuery, DefaultView, ParentServiceInstanceField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ParentServiceInstanceQuery"/> instance.
        /// </summary>
        public ParentServiceInstanceQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// Service instance consuming the service instance of the service level agreement.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>The same <see cref="ParentServiceInstanceQuery"/>, updated to include the "ServiceInstance" sub-query.</returns>
        public ParentServiceInstanceQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstance", query, false);
        }
    }
}
