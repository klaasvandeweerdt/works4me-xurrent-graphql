namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for entities that include product backlog items.
    /// </summary>
    [XurrentInterface()]
    public interface IProductBacklogItem : IDataItem
    {
        /// <summary>
        /// Gets the product backlog associated with this entity.
        /// </summary>
        public ProductBacklog? ProductBacklog { get; }

        /// <summary>
        /// Gets the estimated effort or size for this product backlog item.
        /// </summary>
        public long? ProductBacklogEstimate { get; }

        /// <summary>
        /// Gets the zero-based position of this item within its <see cref="ProductBacklog"/>.
        /// </summary>
        public long? ProductBacklogPosition { get; }
    }
}
