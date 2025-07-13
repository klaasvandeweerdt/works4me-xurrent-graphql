using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="CustomField"/> query class.
    /// </summary>
    public class CustomFieldQuery : Query<CustomField, CustomFieldQuery, DefaultView, CustomFieldField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="CustomFieldQuery"/> instance.
        /// </summary>
        public CustomFieldQuery() : base(string.Empty, false)
        {
        }
    }
}
