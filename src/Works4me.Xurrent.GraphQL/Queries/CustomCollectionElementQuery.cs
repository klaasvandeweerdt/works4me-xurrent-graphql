using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="CustomCollectionElement"/> query class.
    /// </summary>
    public class CustomCollectionElementQuery : Query<CustomCollectionElement, CustomCollectionElementQuery, CustomCollectionElementView, CustomCollectionElementField, CustomCollectionElementFilterField, CustomCollectionElementOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="CustomCollectionElementQuery"/> instance.
        /// </summary>
        public CustomCollectionElementQuery() : base("customCollectionElements", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="CustomCollectionElementQuery"/>, updated to include the "Account" sub-query.</returns>
        public CustomCollectionElementQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Collection of this element.
        /// </summary>
        /// <param name="query">The custom collection query.</param>
        /// <returns>The same <see cref="CustomCollectionElementQuery"/>, updated to include the "CustomCollection" sub-query.</returns>
        public CustomCollectionElementQuery SelectCustomCollection(CustomCollectionQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customCollection", query, false);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom fields query.</param>
        /// <returns>The same <see cref="CustomCollectionElementQuery"/>, updated to include the "CustomFields" sub-query.</returns>
        public CustomCollectionElementQuery SelectCustomFields(CustomFieldQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFields", query, false);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The custom fields attachments query.</param>
        /// <returns>The same <see cref="CustomCollectionElementQuery"/>, updated to include the "CustomFieldsAttachments" sub-query.</returns>
        public CustomCollectionElementQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customFieldsAttachments", query, true);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        /// <param name="query">The information attachments query.</param>
        /// <returns>The same <see cref="CustomCollectionElementQuery"/>, updated to include the "InformationAttachments" sub-query.</returns>
        public CustomCollectionElementQuery SelectInformationAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("informationAttachments", query, true);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translations query.</param>
        /// <returns>The same <see cref="CustomCollectionElementQuery"/>, updated to include the "Translations" sub-query.</returns>
        public CustomCollectionElementQuery SelectTranslations(TranslationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("translations", query, true);
        }

        /// <summary>
        /// <br>Filter the <see cref="CustomCollectionElement">CustomCollectionElement</see> by their custom fields that have been marked as "Filterable" in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.xurrent.com/graphql/input_object/customcollectionelementcustomfilter/">Xurrent developer site</see>.</br>
        /// </summary>
        /// <param name="name">The name of the custom filter (i.e. value of the data-filterable-name attribute of the field in the UI Extension).</param>
        /// <param name="op">The filter operator.</param>
        /// <param name="values">
        /// Use value <c>null</c> to indicate "None".
        /// 
        /// For "text" fields:
        /// • One can start the value with <c>~</c> to get partial matches (start with <c>'~</c> to match on a value starting with <c>~</c>).
        /// 
        /// For "number" and "time" fields:
        /// • One can start the value with <c>&lt;</c>, <c>&gt;</c>, <c>&lt;=</c>, <c>&gt;=</c> to get relative matches.
        /// • Times should be formatted as HH:mm:ss (e.g. <c>16:00:00</c>). The seconds part, <c>:ss</c>, is optional so <c>16:00</c> is also valid.
        /// • <c>&gt;{lower}&lt;{upper}</c> can be used to get matches where the value is more than '{lower}' and less than '{upper}'.
        /// • <c>&gt;={lower}&lt;={upper}</c> can be used to get matches where the value is between '{lower}' and '{upper}'.
        /// • <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and less than '{upper}'.
        /// 
        /// For "date" and "date-time" fields:
        /// • One must supply a single value (and <c>null</c> is not supported).
        /// • Matches are always relative with an optional upper bound.
        /// • Dates should be formatted as <c>yyyy-MM-dd</c> (e.g. <c>2020-05-20</c>).
        /// • Date and time should be formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c> (e.g. <c>2020-05-20T16:00:00Z</c>).
        /// • <c>&gt;={lower}</c> should be used to get matches where the value is at least '{lower}'.
        /// • <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and before '{upper}'.
        /// 
        /// For "select" fields:
        /// • One must supply labels to match in the language of the account (i.e. not the value attributes of the HTML options).
        /// • Matches are case-sensitive.
        /// </param>
        public CustomCollectionElementQuery CustomFilter(string name, FilterOperator op, params string?[] values)
        {
            return AddCustomFilter(name, op, values);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="CustomCollectionElementQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="CustomCollectionElementQuery">CustomCollectionElementQuery</see>, updated to include the "Search" sub-query.</returns>
        public CustomCollectionElementQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
