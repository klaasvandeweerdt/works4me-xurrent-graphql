using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Contact"/> query class.
    /// </summary>
    public class ContactQuery : Query<Contact, ContactQuery, DefaultView, ContactField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ContactQuery"/> instance.
        /// </summary>
        public ContactQuery() : base(string.Empty, true)
        {
        }
    }
}
