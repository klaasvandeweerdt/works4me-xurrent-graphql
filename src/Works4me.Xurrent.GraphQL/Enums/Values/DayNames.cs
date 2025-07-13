using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The day names values.
    /// </summary>
    public enum DayNames
    {
        /// <summary>
        /// Friday.
        /// </summary>
        [XurrentEnum("friday")]
        Friday,

        /// <summary>
        /// Monday.
        /// </summary>
        [XurrentEnum("monday")]
        Monday,

        /// <summary>
        /// Saturday.
        /// </summary>
        [XurrentEnum("saturday")]
        Saturday,

        /// <summary>
        /// Sunday.
        /// </summary>
        [XurrentEnum("sunday")]
        Sunday,

        /// <summary>
        /// Thursday.
        /// </summary>
        [XurrentEnum("thursday")]
        Thursday,

        /// <summary>
        /// Tuesday.
        /// </summary>
        [XurrentEnum("tuesday")]
        Tuesday,

        /// <summary>
        /// Wednesday.
        /// </summary>
        [XurrentEnum("wednesday")]
        Wednesday
    }
}
