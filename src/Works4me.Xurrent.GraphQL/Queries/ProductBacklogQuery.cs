using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProductBacklog"/> query class.
    /// </summary>
    public class ProductBacklogQuery : Query<ProductBacklog, ProductBacklogQuery, ProductBacklogView, ProductBacklogField, ProductBacklogFilterField, ProductBacklogOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ProductBacklogQuery"/> instance.
        /// </summary>
        public ProductBacklogQuery() : base("productBacklogs", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ProductBacklogQuery"/>, updated to include the "Account" sub-query.</returns>
        public ProductBacklogQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        /// <param name="query">The description attachments query.</param>
        /// <returns>The same <see cref="ProductBacklogQuery"/>, updated to include the "DescriptionAttachments" sub-query.</returns>
        public ProductBacklogQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("descriptionAttachments", query, true);
        }

        /// <summary>
        /// Items on this backlog.<br />
        /// A new instance of the respective query type is created when the parameter is not provided or <c>null</c>.<br />
        /// </summary>
        /// <param name="problemQuery">The problem query.</param>
        /// <param name="requestQuery">The request query.</param>
        /// <returns>The same <see cref="ProductBacklogQuery"/>, updated to include the sub-queries.</returns>
        public ProductBacklogQuery SelectItemsAll(
            ProblemQuery? problemQuery = null,
            RequestQuery? requestQuery = null)
        {
            ProductBacklogQuery query = SelectOnType("items", problemQuery ?? new(), true);
            query = query.SelectOnType("items", requestQuery ?? new(), true);
            return query;
        }

        /// <summary>
        /// Items on this backlog.<br />
        /// Use this method along with other <c>SelectItems()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectItems()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The items query.</param>
        /// <returns>The same <see cref="ProductBacklogQuery"/>, updated to include the "Items" sub-query.</returns>
        public ProductBacklogQuery SelectItems(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("items", query, true);
        }

        /// <summary>
        /// Items on this backlog.<br />
        /// Use this method along with other <c>SelectItems()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectItems()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The items query.</param>
        /// <returns>The same <see cref="ProductBacklogQuery"/>, updated to include the "Items" sub-query.</returns>
        public ProductBacklogQuery SelectItems(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("items", query, true);
        }

        /// <summary>
        /// Person responsible for maximizing the value of the work done based on this product backlog.
        /// </summary>
        /// <param name="query">The product owner query.</param>
        /// <returns>The same <see cref="ProductBacklogQuery"/>, updated to include the "ProductOwner" sub-query.</returns>
        public ProductBacklogQuery SelectProductOwner(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("productOwner", query, false);
        }

        /// <summary>
        /// Scrum workspaces taking items from this backlog when planning their sprints.
        /// </summary>
        /// <param name="query">The scrum workspaces query.</param>
        /// <returns>The same <see cref="ProductBacklogQuery"/>, updated to include the "ScrumWorkspaces" sub-query.</returns>
        public ProductBacklogQuery SelectScrumWorkspaces(ScrumWorkspaceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("scrumWorkspaces", query, true);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ProductBacklogQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ProductBacklogQuery">ProductBacklogQuery</see>, updated to include the "Search" sub-query.</returns>
        public ProductBacklogQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
