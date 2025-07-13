using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Address"/> query class.
    /// </summary>
    public class AddressQuery : Query<Address, AddressQuery, DefaultView, AddressField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AddressQuery"/> instance.
        /// </summary>
        public AddressQuery() : base(string.Empty, true)
        {
        }
    }
}
