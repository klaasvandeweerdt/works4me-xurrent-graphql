using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AccountDesign"/> query class.
    /// </summary>
    public class AccountDesignQuery : Query<AccountDesign, AccountDesignQuery, DefaultView, AccountDesignField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AccountDesignQuery"/> instance.
        /// </summary>
        public AccountDesignQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="AccountDesignQuery"/>, updated to include the "Account" sub-query.</returns>
        public AccountDesignQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="AccountDesignQuery"/>, updated to include the "Translations" sub-query.</returns>
        public AccountDesignQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }
    }
}
