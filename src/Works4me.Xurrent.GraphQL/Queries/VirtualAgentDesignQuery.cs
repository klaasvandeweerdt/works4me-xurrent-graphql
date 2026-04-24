using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="VirtualAgentDesign"/> query class.
    /// </summary>
    public class VirtualAgentDesignQuery : Query<VirtualAgentDesign, VirtualAgentDesignQuery, DefaultView, VirtualAgentDesignField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="VirtualAgentDesignQuery"/> instance.
        /// </summary>
        public VirtualAgentDesignQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="VirtualAgentDesignQuery"/>, updated to include the "Account" sub-query.</returns>
        public VirtualAgentDesignQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }
    }
}
