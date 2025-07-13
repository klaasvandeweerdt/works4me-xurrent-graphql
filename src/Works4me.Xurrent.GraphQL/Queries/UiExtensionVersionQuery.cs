using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="UiExtensionVersion"/> query class.
    /// </summary>
    public class UiExtensionVersionQuery : Query<UiExtensionVersion, UiExtensionVersionQuery, DefaultView, UiExtensionVersionField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="UiExtensionVersionQuery"/> instance.
        /// </summary>
        public UiExtensionVersionQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// UI extension this version belongs to.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>The same <see cref="UiExtensionVersionQuery"/>, updated to include the "UiExtension" sub-query.</returns>
        public UiExtensionVersionQuery SelectUiExtension(UiExtensionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("uiExtension", query, false);
        }
    }
}
