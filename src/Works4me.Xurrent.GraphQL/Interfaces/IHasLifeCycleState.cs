namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for entities that expose their lifecycle state.
    /// </summary>
    [XurrentInterface()]
    public interface IHasLifeCycleState : IDataItem
    {
        /// <summary>
        /// Gets the life cycle state of this entity.
        /// </summary>
        public LifeCycleState? LifeCycleState { get; }
    }
}
