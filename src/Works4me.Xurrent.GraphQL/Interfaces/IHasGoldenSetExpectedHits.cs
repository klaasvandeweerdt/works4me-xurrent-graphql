namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for golden step expected hit items.
    /// </summary>
    [XurrentInterface()]
    public interface IHasGoldenSetExpectedHits : IDataItem
    {
        /// <summary>
        /// Gets the golden set items associated with this entity.
        /// </summary>
        public ReadOnlyDataCollection<GoldenSetItem>? GoldenSetItems { get; }
    }
}
