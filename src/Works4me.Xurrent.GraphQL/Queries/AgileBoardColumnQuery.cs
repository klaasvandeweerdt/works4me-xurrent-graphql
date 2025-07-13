using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="AgileBoardColumn"/> query class.
    /// </summary>
    public class AgileBoardColumnQuery : Query<AgileBoardColumn, AgileBoardColumnQuery, DefaultView, AgileBoardColumnField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="AgileBoardColumnQuery"/> instance.
        /// </summary>
        public AgileBoardColumnQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="AgileBoardColumnQuery"/>, updated to include the "Account" sub-query.</returns>
        public AgileBoardColumnQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Agile board the column is part of.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>The same <see cref="AgileBoardColumnQuery"/>, updated to include the "AgileBoard" sub-query.</returns>
        public AgileBoardColumnQuery SelectAgileBoard(AgileBoardQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("agileBoard", query, false);
        }

        /// <summary>
        /// Items in this column.<br />
        /// A new instance of the respective query type is created when the parameter is not provided or <c>null</c>.<br />
        /// </summary>
        /// <param name="problemQuery">The problem query.</param>
        /// <param name="projectTaskQuery">The project task query.</param>
        /// <param name="requestQuery">The request query.</param>
        /// <param name="workflowTaskQuery">The workflow task query.</param>
        /// <returns>The same <see cref="AgileBoardColumnQuery"/>, updated to include the sub-queries.</returns>
        public AgileBoardColumnQuery SelectItemsAll(
            ProblemQuery? problemQuery = null,
            ProjectTaskQuery? projectTaskQuery = null,
            RequestQuery? requestQuery = null,
            WorkflowTaskQuery? workflowTaskQuery = null)
        {
            AgileBoardColumnQuery query = SelectOnType("items", problemQuery ?? new(), true);
            query = query.SelectOnType("items", projectTaskQuery ?? new(), true);
            query = query.SelectOnType("items", requestQuery ?? new(), true);
            query = query.SelectOnType("items", workflowTaskQuery ?? new(), true);
            return query;
        }

        /// <summary>
        /// Items in this column.<br />
        /// Use this method along with other <c>SelectItems()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectItems()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The items query.</param>
        /// <returns>The same <see cref="AgileBoardColumnQuery"/>, updated to include the "Items" sub-query.</returns>
        public AgileBoardColumnQuery SelectItems(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("items", query, true);
        }

        /// <summary>
        /// Items in this column.<br />
        /// Use this method along with other <c>SelectItems()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectItems()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The items query.</param>
        /// <returns>The same <see cref="AgileBoardColumnQuery"/>, updated to include the "Items" sub-query.</returns>
        public AgileBoardColumnQuery SelectItems(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("items", query, true);
        }

        /// <summary>
        /// Items in this column.<br />
        /// Use this method along with other <c>SelectItems()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectItems()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The items query.</param>
        /// <returns>The same <see cref="AgileBoardColumnQuery"/>, updated to include the "Items" sub-query.</returns>
        public AgileBoardColumnQuery SelectItems(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("items", query, true);
        }

        /// <summary>
        /// Items in this column.<br />
        /// Use this method along with other <c>SelectItems()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectItems()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The items query.</param>
        /// <returns>The same <see cref="AgileBoardColumnQuery"/>, updated to include the "Items" sub-query.</returns>
        public AgileBoardColumnQuery SelectItems(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("items", query, true);
        }

        /// <summary>
        /// Person to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        /// <param name="query">The member query.</param>
        /// <returns>The same <see cref="AgileBoardColumnQuery"/>, updated to include the "Member" sub-query.</returns>
        public AgileBoardColumnQuery SelectMember(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("member", query, false);
        }

        /// <summary>
        /// Team to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>The same <see cref="AgileBoardColumnQuery"/>, updated to include the "Team" sub-query.</returns>
        public AgileBoardColumnQuery SelectTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("team", query, false);
        }
    }
}
