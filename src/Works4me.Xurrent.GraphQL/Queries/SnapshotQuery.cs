using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Snapshot"/> query class.
    /// </summary>
    public class SnapshotQuery : Query<Snapshot, SnapshotQuery, DefaultView, SnapshotField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SnapshotQuery"/> instance.
        /// </summary>
        public SnapshotQuery() : base(string.Empty, false)
        {
        }
    }
}
