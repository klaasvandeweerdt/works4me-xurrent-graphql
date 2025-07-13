namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for entities that represent an object with an identifier.
    /// </summary>
    [XurrentInterface()]
    public interface INode : IDataItem
    {
        /// <summary>
        /// Gets the unique identifier of the object.
        /// </summary>
        public string Id { get; }
    }
}
