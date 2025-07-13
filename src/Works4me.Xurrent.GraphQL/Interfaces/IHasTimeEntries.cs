namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for entities that include time entries.
    /// </summary>
    [XurrentInterface()]
    public interface IHasTimeEntries : IDataItem
    {
        /// <summary>
        /// Gets the time entries associated with this entity.
        /// </summary>
        public ReadOnlyDataCollection<TimeEntry>? TimeEntries { get; }
    }
}
