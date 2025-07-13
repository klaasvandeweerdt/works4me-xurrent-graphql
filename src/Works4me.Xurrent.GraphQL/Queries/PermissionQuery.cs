using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Permission"/> query class.
    /// </summary>
    public class PermissionQuery : Query<Permission, PermissionQuery, DefaultView, PermissionField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="PermissionQuery"/> instance.
        /// </summary>
        public PermissionQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// Account for which the person has permissions.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="PermissionQuery"/>, updated to include the "Account" sub-query.</returns>
        public PermissionQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }
    }
}
