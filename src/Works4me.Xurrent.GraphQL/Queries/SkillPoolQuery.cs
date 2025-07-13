using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SkillPool"/> query class.
    /// </summary>
    public class SkillPoolQuery : Query<SkillPool, SkillPoolQuery, SkillPoolView, SkillPoolField, SkillPoolFilterField, SkillPoolOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SkillPoolQuery"/> instance.
        /// </summary>
        public SkillPoolQuery() : base("skillPools", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="SkillPoolQuery"/>, updated to include the "Account" sub-query.</returns>
        public SkillPoolQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Effort classes linked to the skill pool.
        /// </summary>
        /// <param name="query">The effort classes query.</param>
        /// <returns>The same <see cref="SkillPoolQuery"/>, updated to include the "EffortClasses" sub-query.</returns>
        public SkillPoolQuery SelectEffortClasses(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClasses", query, true);
        }

        /// <summary>
        /// The manager or supervisor of the skill pool. This person is able to maintain the information about the skill pool. The manager of a skill pool does not need to be a member of the skill pool.
        /// </summary>
        /// <param name="query">The manager query.</param>
        /// <returns>The same <see cref="SkillPoolQuery"/>, updated to include the "Manager" sub-query.</returns>
        public SkillPoolQuery SelectManager(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("manager", query, false);
        }

        /// <summary>
        /// People linked as a member to the skill pool.
        /// </summary>
        /// <param name="query">The members query.</param>
        /// <returns>The same <see cref="SkillPoolQuery"/>, updated to include the "Members" sub-query.</returns>
        public SkillPoolQuery SelectMembers(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("members", query, true);
        }

        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The remarks attachments query.</param>
        /// <returns>The same <see cref="SkillPoolQuery"/>, updated to include the "RemarksAttachments" sub-query.</returns>
        public SkillPoolQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("remarksAttachments", query, true);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="SkillPoolQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="SkillPoolQuery">SkillPoolQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public SkillPoolQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
