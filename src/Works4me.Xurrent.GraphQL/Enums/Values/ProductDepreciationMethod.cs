using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The product depreciation method values.
    /// </summary>
    public enum ProductDepreciationMethod
    {
        /// <summary>
        /// Double declining balance.
        /// </summary>
        [XurrentEnum("double_declining_balance")]
        DoubleDecliningBalance,

        /// <summary>
        /// Not depreciated.
        /// </summary>
        [XurrentEnum("not_depreciated")]
        NotDepreciated,

        /// <summary>
        /// Reducing balance or diminishing value.
        /// </summary>
        [XurrentEnum("reducing_balance")]
        ReducingBalance,

        /// <summary>
        /// Straight line or prime cost.
        /// </summary>
        [XurrentEnum("straight_line")]
        StraightLine,

        /// <summary>
        /// Sum of the year s digits.
        /// </summary>
        [XurrentEnum("sum_of_the_years_digits")]
        SumOfTheYearsDigits
    }
}
