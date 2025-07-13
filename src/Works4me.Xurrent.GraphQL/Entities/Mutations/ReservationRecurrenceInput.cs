using System;
using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/reservationrecurrenceinput/">ReservationRecurrenceInput</see> in Xurrent.
    /// </summary>
    public sealed class ReservationRecurrenceInput : PropertyChangeSet
    {
        private RecurrenceFrequency? _frequency;
        private TimeSpan? _timeOfDay;
        private string? _timeZone;
        private long? _interval;
#if NET6_0_OR_GREATER
        private DateOnly? _startDate;
#else
        private DateTime? _startDate;
#endif
#if NET6_0_OR_GREATER
        private DateOnly? _endDate;
#else
        private DateTime? _endDate;
#endif
        private Collection<long>? _day;
        private Collection<long>? _dayOfMonth;
        private bool? _dayOfWeek;
        private RecurrenceDayOfWeekIndex? _dayOfWeekIndex;
        private DayNames? _dayOfWeekDay;
        private Collection<long>? _monthOfYear;

        /// <summary>
        /// The frequency of the recurrence.
        /// </summary>
        [XurrentField("frequency")]
        public RecurrenceFrequency? Frequency
        {
            get => _frequency;
            set => _frequency = Set("frequency", value);
        }

        /// <summary>
        /// The time of day to start the Recurrence.
        /// </summary>
        [XurrentField("timeOfDay")]
        public TimeSpan? TimeOfDay
        {
            get => _timeOfDay;
            set => _timeOfDay = Set("timeOfDay", value);
        }

        /// <summary>
        /// The time zone for the <c>timeOfDay</c> field.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone
        {
            get => _timeZone;
            set => _timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// The interval of the Frequency, e.g. every 2nd week or every 10th day.
        /// </summary>
        [XurrentField("interval")]
        public long? Interval
        {
            get => _interval;
            set => _interval = Set("interval", value);
        }

        /// <summary>
        /// The date at which to start the Recurrence.
        /// </summary>
        [XurrentField("startDate")]
#if NET6_0_OR_GREATER
        public DateOnly? StartDate
#else
        public DateTime? StartDate
#endif
        {
            get => _startDate;
            set => _startDate = Set("startDate", value);
        }

        /// <summary>
        /// The date at which to end the Recurrence.
        /// </summary>
        [XurrentField("endDate")]
#if NET6_0_OR_GREATER
        public DateOnly? EndDate
#else
        public DateTime? EndDate
#endif
        {
            get => _endDate;
            set => _endDate = Set("endDate", value);
        }

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
        [XurrentField("day")]
        public Collection<long>? Day
        {
            get => _day;
            set => _day = Set("day", value);
        }

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
        [XurrentField("dayOfMonth")]
        public Collection<long>? DayOfMonth
        {
            get => _dayOfMonth;
            set => _dayOfMonth = Set("dayOfMonth", value);
        }

        /// <summary>
        /// Indicates whether or not the <c>dayOfWeekIndex</c> and <c>dayOfWeekDay</c> values should be considered. Can only be set to <c>true</c> when <c>frequency</c> is <c>monthly</c> or <c>yearly</c>.
        /// </summary>
        [XurrentField("dayOfWeek")]
        public bool? DayOfWeek
        {
            get => _dayOfWeek;
            set => _dayOfWeek = Set("dayOfWeek", value);
        }

        /// <summary>
        /// _Required_ when <c>dayOfWeek</c> is <c>true</c>, ignored in all other cases.
        /// </summary>
        [XurrentField("dayOfWeekIndex")]
        public RecurrenceDayOfWeekIndex? DayOfWeekIndex
        {
            get => _dayOfWeekIndex;
            set => _dayOfWeekIndex = Set("dayOfWeekIndex", value);
        }

        /// <summary>
        /// _Required_ when <c>dayOfWeek</c> is <c>true</c>, ignored in all other cases.
        /// </summary>
        [XurrentField("dayOfWeekDay")]
        public DayNames? DayOfWeekDay
        {
            get => _dayOfWeekDay;
            set => _dayOfWeekDay = Set("dayOfWeekDay", value);
        }

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
        [XurrentField("monthOfYear")]
        public Collection<long>? MonthOfYear
        {
            get => _monthOfYear;
            set => _monthOfYear = Set("monthOfYear", value);
        }
    }
}
