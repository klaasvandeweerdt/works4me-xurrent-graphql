namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for entities that include automation rules.
    /// </summary>
    [XurrentInterface()]
    public interface IHasAutomationRules : IDataItem
    {
        /// <summary>
        /// Gets the automation rules associated with this entity.
        /// </summary>
        public ReadOnlyDataCollection<AutomationRule>? AutomationRules { get; }
    }
}
