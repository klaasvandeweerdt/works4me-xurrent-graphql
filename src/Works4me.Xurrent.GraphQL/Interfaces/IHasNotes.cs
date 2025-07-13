namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for entities that include notes.
    /// </summary>
    [XurrentInterface()]
    public interface IHasNotes : IDataItem
    {
        /// <summary>
        /// Gets the notes associated with this entity.
        /// </summary>
        public ReadOnlyDataCollection<Note>? Notes { get; }
    }
}
