using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Account"/> query class.
    /// </summary>
    public class AccountQuery : Query<Account, AccountQuery, DefaultView, AccountField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AccountQuery"/> instance.
        /// </summary>
        public AccountQuery() : base("account", false)
        {
        }

        /// <summary>
        /// The design of the account.
        /// </summary>
        /// <param name="query">The design query.</param>
        /// <returns>The same <see cref="AccountQuery"/>, updated to include the "Design" sub-query.</returns>
        public AccountQuery SelectDesign(AccountDesignQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("design", query, false);
        }

        /// <summary>
        /// The directory account of the current support domain.
        /// </summary>
        /// <param name="query">The directory account query.</param>
        /// <returns>The same <see cref="AccountQuery"/>, updated to include the "DirectoryAccount" sub-query.</returns>
        public AccountQuery SelectDirectoryAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("directoryAccount", query, false);
        }

        /// <summary>
        /// The organization for which the account was prepared.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>The same <see cref="AccountQuery"/>, updated to include the "Organization" sub-query.</returns>
        public AccountQuery SelectOrganization(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("organization", query, false);
        }
    }
}
