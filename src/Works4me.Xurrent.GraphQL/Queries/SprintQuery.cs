using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Sprint"/> query class.
    /// </summary>
    public class SprintQuery : Query<Sprint, SprintQuery, SprintView, SprintField, SprintFilterField, SprintOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SprintQuery"/> instance.
        /// </summary>
        public SprintQuery() : base("sprints", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="SprintQuery"/>, updated to include the "Account" sub-query.</returns>
        public SprintQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="SprintQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public SprintQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// Scrum workspace this sprint belongs to.
        /// </summary>
        /// <param name="query">The scrum workspace query.</param>
        /// <returns>The same <see cref="SprintQuery"/>, updated to include the "ScrumWorkspace" sub-query.</returns>
        public SprintQuery SelectScrumWorkspace(ScrumWorkspaceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("scrumWorkspace", query, false);
        }

        /// <summary>
        /// Items in this sprint.
        /// </summary>
        /// <param name="query">The sprint backlog items query.</param>
        /// <returns>The same <see cref="SprintQuery"/>, updated to include the "SprintBacklogItems" sub-query.</returns>
        public SprintQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("sprintBacklogItems", query, true);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="SprintQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="SprintQuery">SprintQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public SprintQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
