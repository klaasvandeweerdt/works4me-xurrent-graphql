namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for entities that represent items on an Agile board.
    /// </summary>
    [XurrentInterface()]
    public interface IAgileBoardItem : IDataItem
    {
        /// <summary>
        /// Gets the <see cref="AgileBoard"/> that this item belongs to.
        /// </summary>
        public AgileBoard? AgileBoard { get; }

        /// <summary>
        /// Gets the <see cref="AgileBoardColumn"/> in which this item is currently placed.
        /// </summary>
        public AgileBoardColumn? AgileBoardColumn { get; }

        /// <summary>
        /// Gets the zero-based position of this item within its <see cref="AgileBoardColumn"/>.
        /// </summary>
        public long? AgileBoardColumnPosition { get; }
    }
}
