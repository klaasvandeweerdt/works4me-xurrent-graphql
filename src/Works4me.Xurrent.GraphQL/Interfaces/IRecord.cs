using System;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Interface for entities that provide an identifier, account association, and audit timestamps.
    /// </summary>
    [XurrentInterface()]
    public interface IRecord : IDataItem
    {
        /// <summary>
        /// Gets the account associated with this record.
        /// </summary>
        public Account? Account { get; }

        /// <summary>
        /// Gets the timestamp when the record was created.
        /// </summary>
        public DateTime? CreatedAt { get; }

        /// <summary>
        /// Gets the unique identifier of the record.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the timestamp when the record was last updated.
        /// </summary>
        public DateTime? UpdatedAt { get; }
    }
}
