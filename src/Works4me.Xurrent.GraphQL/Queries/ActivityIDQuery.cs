using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ActivityID"/> query class.
    /// </summary>
    public class ActivityIDQuery : Query<ActivityID, ActivityIDQuery, DefaultView, ActivityIDField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ActivityIDQuery"/> instance.
        /// </summary>
        public ActivityIDQuery() : base(string.Empty, false)
        {
        }
    }
}
