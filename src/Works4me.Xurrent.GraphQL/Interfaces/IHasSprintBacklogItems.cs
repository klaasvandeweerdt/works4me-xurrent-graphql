namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for entities that include sprint backlog items.
    /// </summary>
    [XurrentInterface()]
    public interface IHasSprintBacklogItems : IDataItem
    {
        /// <summary>
        /// Gets the sprint backlog items associated with this entity.
        /// </summary>
        public ReadOnlyDataCollection<SprintBacklogItem>? SprintBacklogItems { get; }
    }
}
