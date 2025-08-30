using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ScrumWorkspace"/> query class.
    /// </summary>
    public class ScrumWorkspaceQuery : Query<ScrumWorkspace, ScrumWorkspaceQuery, ScrumWorkspaceView, ScrumWorkspaceField, ScrumWorkspaceFilterField, ScrumWorkspaceOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ScrumWorkspaceQuery"/> instance.
        /// </summary>
        public ScrumWorkspaceQuery() : base("scrumWorkspaces", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ScrumWorkspaceQuery"/>, updated to include the "Account" sub-query.</returns>
        public ScrumWorkspaceQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Agile board used to track the progress of this workspace's active sprint.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>The same <see cref="ScrumWorkspaceQuery"/>, updated to include the "AgileBoard" sub-query.</returns>
        public ScrumWorkspaceQuery SelectAgileBoard(AgileBoardQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoard", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="ScrumWorkspaceQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public ScrumWorkspaceQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// Product backlog used when planning sprints.
        /// </summary>
        /// <param name="query">The product backlog query.</param>
        /// <returns>The same <see cref="ScrumWorkspaceQuery"/>, updated to include the "ProductBacklog" sub-query.</returns>
        public ScrumWorkspaceQuery SelectProductBacklog(ProductBacklogQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("productBacklog", query, false);
        }

        /// <summary>
        /// Sprints of this scrum workspace.
        /// </summary>
        /// <param name="query">The sprints query.</param>
        /// <returns>The same <see cref="ScrumWorkspaceQuery"/>, updated to include the "Sprints" sub-query.</returns>
        public ScrumWorkspaceQuery SelectSprints(SprintQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("sprints", query, true);
        }

        /// <summary>
        /// Team planning their work using this scrum workspace.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>The same <see cref="ScrumWorkspaceQuery"/>, updated to include the "Team" sub-query.</returns>
        public ScrumWorkspaceQuery SelectTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("team", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ScrumWorkspaceQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ScrumWorkspaceQuery">ScrumWorkspaceQuery</see>, updated to include the "Search" sub-query.</returns>
        public ScrumWorkspaceQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
