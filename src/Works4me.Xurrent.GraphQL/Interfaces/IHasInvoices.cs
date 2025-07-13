namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for entities that include invoices.
    /// </summary>
    [XurrentInterface()]
    public interface IHasInvoices : IDataItem
    {
        /// <summary>
        /// Gets the invoices associated with this entity.
        /// </summary>
        public ReadOnlyDataCollection<Invoice>? Invoices { get; }
    }
}
