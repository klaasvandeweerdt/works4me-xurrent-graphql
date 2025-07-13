namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for entities that include time translations.
    /// </summary>
    [XurrentInterface()]
    public interface IHasTranslations : IDataItem
    {
        /// <summary>
        /// Gets the translations associated with this entity.
        /// </summary>
        public ReadOnlyDataCollection<Translation>? Translations { get; }
    }
}
