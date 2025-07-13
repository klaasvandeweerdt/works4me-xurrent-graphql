using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/agileboardcolumn/">AgileBoardColumn</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("AgileBoardColumn")]
    public sealed class AgileBoardColumn : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Type of action to perform when an item is added to this column.
        /// </summary>
        [XurrentField("actionType")]
        public AgileBoardColumnActionType? ActionType { get; internal set; }

        /// <summary>
        /// Agile board the column is part of.
        /// </summary>
        [XurrentField("agileBoard")]
        public AgileBoard? AgileBoard { get; internal set; }

        /// <summary>
        /// Will the assigned person field of the item be cleared when the action type is <c>assign</c> and an item is added to this column?.
        /// </summary>
        [XurrentField("clearMember")]
        public bool? ClearMember { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Type of dialog to open when an item is added to this column.
        /// </summary>
        [XurrentField("dialogType")]
        public AgileBoardColumnDialogType? DialogType { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        [XurrentField("items")]
        internal PagedResponse<IAgileBoardItem>? ItemsCollection { get; set; }
        /// <summary>
        /// Items in this column.
        /// </summary>
        public ReadOnlyDataCollection<IAgileBoardItem>? Items { get => ItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<IAgileBoardItem>(ItemsCollection.Data); }

        /// <summary>
        /// Person to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        [XurrentField("member")]
        public Person? Member { get; internal set; }

        /// <summary>
        /// Name of the column.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// Relative position of the column.
        /// </summary>
        [XurrentField("position")]
        public long? Position { get; internal set; }

        /// <summary>
        /// Items in this column will be removed from the board if they are not explicitly moved in this many days.
        /// </summary>
        [XurrentField("removeAfter")]
        public long? RemoveAfter { get; internal set; }

        /// <summary>
        /// Team to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        [XurrentField("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Work-in-progress limit for the column.
        /// </summary>
        [XurrentField("wipLimit")]
        public long? WipLimit { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
            if (data is AgileBoardColumn agileBoardColumn)
            {
                ItemsCollection?.Data?.AddRange(agileBoardColumn.Items);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ItemsCollection.GetPageInfo("items", depth))
                    yield return pageInfo;
        }
    }
}
