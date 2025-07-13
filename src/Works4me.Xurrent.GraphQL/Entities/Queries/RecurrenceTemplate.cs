using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/recurrencetemplate/">RecurrenceTemplate</see> in Xurrent.
    /// </summary>
    [XurrentEntity("RecurrenceTemplate")]
    public sealed class RecurrenceTemplate : IDataItem
    {
        /// <summary>
        /// Select a calendar to skip occurrences of the recurrence during off-hours and holidays.
        /// </summary>
        [XurrentField("calendar", IsDefaultQueryProperty = true)]
        public Calendar? Calendar { get; internal set; }

        /// <summary>
        /// _Required_ when <c>frequency</c> is <c>daily</c>, ignored in all other cases. List of days of the week, e.g. <c>1,2,3,4,5</c>.<br />
        ///   • <c>0</c>: Sunday.<br />
        ///   • <c>1</c>: Monday.<br />
        ///   • <c>2</c>: Tuesday.<br />
        ///   • <c>3</c>: Wednesday.<br />
        ///   • <c>4</c>: Thursday.<br />
        ///   • <c>5</c>: Friday.<br />
        ///   • <c>6</c>: Saturday.<br />
        /// </summary>
        [XurrentField("day", IsDefaultQueryProperty = true)]
        public IReadOnlyList<long>? Day { get; internal set; }

        /// <summary>
        /// _Required_ when <c>frequency</c> is <c>monthly</c> and <c>day_of_week</c> is <c>false</c>, ignored in all other cases. List of days of the month, e.g. <c>11,21,-1</c>.<br />
        ///   • <c>1</c>: Day one.<br />
        ///   • <c>2</c>: Day two.<br />
        ///   • <c>3</c>: Day three.<br />
        ///   • ...<br />
        ///   • <c>30</c>: Day thirty.<br />
        ///   • <c>31</c>: Day thirty-one.<br />
        ///   • <c>-1</c>: Last day of month.<br />
        /// </summary>
        [XurrentField("dayOfMonth", IsDefaultQueryProperty = true)]
        public IReadOnlyList<long>? DayOfMonth { get; internal set; }

        /// <summary>
        /// Indicates whether or not the <c>dayOfWeekIndex</c> and <c>dayOfWeekDay</c> values should be considered. Can only be set to <c>true</c> when <c>frequency</c> is <c>monthly</c> or <c>yearly</c>.
        /// </summary>
        [XurrentField("dayOfWeek", IsDefaultQueryProperty = true)]
        public bool? DayOfWeek { get; internal set; }

        /// <summary>
        /// _Required_ when <c>dayOfWeek</c> is <c>true</c>, ignored in all other cases.
        /// </summary>
        [XurrentField("dayOfWeekDay", IsDefaultQueryProperty = true)]
        public DayNames? DayOfWeekDay { get; internal set; }

        /// <summary>
        /// _Required_ when <c>dayOfWeek</c> is <c>true</c>, ignored in all other cases.
        /// </summary>
        [XurrentField("dayOfWeekIndex", IsDefaultQueryProperty = true)]
        public RecurrenceDayOfWeekIndex? DayOfWeekIndex { get; internal set; }

        /// <summary>
        /// Whether recurrency should be temporarily disabled.
        /// </summary>
        [XurrentField("disabled", IsDefaultQueryProperty = true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The frequency of the recurrency.
        /// </summary>
        [XurrentField("frequency", IsDefaultQueryProperty = true)]
        public RecurrenceFrequency? Frequency { get; internal set; }

        /// <summary>
        /// The interval of the Frequency, e.g. every 2nd week or every 10th day.
        /// </summary>
        [XurrentField("interval", IsDefaultQueryProperty = true)]
        public long? Interval { get; internal set; }

        /// <summary>
        /// _Required_ when <c>frequency</c> is <c>yearly</c>, ignored in all other cases. List of months of the year, e.g. <c>3,6,9,12</c>.<br />
        ///   • <c>1</c>: January.<br />
        ///   • <c>2</c>: February.<br />
        ///   • <c>3</c>: March.<br />
        ///   • <c>4</c>: April.<br />
        ///   • <c>5</c>: May.<br />
        ///   • <c>6</c>: June.<br />
        ///   • <c>7</c>: July.<br />
        ///   • <c>8</c>: August.<br />
        ///   • <c>9</c>: September.<br />
        ///   • <c>10</c>: October.<br />
        ///   • <c>11</c>: November.<br />
        ///   • <c>12</c>: December.<br />
        /// </summary>
        [XurrentField("monthOfYear", IsDefaultQueryProperty = true)]
        public IReadOnlyList<long>? MonthOfYear { get; internal set; }

        /// <summary>
        /// The time of day to start the scheduled occurrence.
        /// </summary>
        [XurrentField("timeOfDay", IsDefaultQueryProperty = true)]
        public TimeSpan? TimeOfDay { get; internal set; }

        /// <summary>
        /// The time zone for the <c>timeOfDay</c> field.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone", IsDefaultQueryProperty = true)]
        public string? TimeZone { get; internal set; }

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
