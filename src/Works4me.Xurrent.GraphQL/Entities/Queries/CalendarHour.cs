using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/calendarhour/">CalendarHour</see> in Xurrent.
    /// </summary>
    [XurrentEntity("CalendarHour")]
    public sealed class CalendarHour : IDataItem
    {
        /// <summary>
        /// The time at which the calendar becomes active on the given weekday.
        /// </summary>
        [XurrentField("timeFrom", IsDefaultQueryProperty = true)]
        public TimeSpan? TimeFrom { get; internal set; }

        /// <summary>
        /// The time at which the calendar stops being active on the given weekday.
        /// </summary>
        [XurrentField("timeUntil", IsDefaultQueryProperty = true)]
        public TimeSpan? TimeUntil { get; internal set; }

        /// <summary>
        /// The day of the week.
        /// </summary>
        [XurrentField("weekday", IsDefaultQueryProperty = true)]
        public Weekday? Weekday { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return GetHashCode().ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return Enumerable.Empty<ExecutionPageInfo>();
        }
    }
}
