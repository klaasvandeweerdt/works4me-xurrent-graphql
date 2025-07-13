using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="SprintBacklogItem"/> query class.
    /// </summary>
    public class SprintBacklogItemQuery : Query<SprintBacklogItem, SprintBacklogItemQuery, DefaultView, SprintBacklogItemField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="SprintBacklogItemQuery"/> instance.
        /// </summary>
        public SprintBacklogItemQuery() : base(string.Empty, true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="SprintBacklogItemQuery"/>, updated to include the "Account" sub-query.</returns>
        public SprintBacklogItemQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// Record on the sprint backlog.<br />
        /// A new instance of the respective query type is created when the parameter is not provided or <c>null</c>.<br />
        /// </summary>
        /// <param name="problemQuery">The problem query.</param>
        /// <param name="projectTaskQuery">The project task query.</param>
        /// <param name="requestQuery">The request query.</param>
        /// <param name="workflowTaskQuery">The workflow task query.</param>
        /// <returns>The same <see cref="SprintBacklogItemQuery"/>, updated to include the sub-queries.</returns>
        public SprintBacklogItemQuery SelectRecordAll(
            ProblemQuery? problemQuery = null,
            ProjectTaskQuery? projectTaskQuery = null,
            RequestQuery? requestQuery = null,
            WorkflowTaskQuery? workflowTaskQuery = null)
        {
            SprintBacklogItemQuery query = SelectOnType("record", problemQuery ?? new(), false);
            query = query.SelectOnType("record", projectTaskQuery ?? new(), false);
            query = query.SelectOnType("record", requestQuery ?? new(), false);
            query = query.SelectOnType("record", workflowTaskQuery ?? new(), false);
            return query;
        }

        /// <summary>
        /// Record on the sprint backlog.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="SprintBacklogItemQuery"/>, updated to include the "Record" sub-query.</returns>
        public SprintBacklogItemQuery SelectRecord(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }

        /// <summary>
        /// Record on the sprint backlog.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="SprintBacklogItemQuery"/>, updated to include the "Record" sub-query.</returns>
        public SprintBacklogItemQuery SelectRecord(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }

        /// <summary>
        /// Record on the sprint backlog.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="SprintBacklogItemQuery"/>, updated to include the "Record" sub-query.</returns>
        public SprintBacklogItemQuery SelectRecord(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }

        /// <summary>
        /// Record on the sprint backlog.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="SprintBacklogItemQuery"/>, updated to include the "Record" sub-query.</returns>
        public SprintBacklogItemQuery SelectRecord(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }

        /// <summary>
        /// Sprint this record is part of.
        /// </summary>
        /// <param name="query">The sprint query.</param>
        /// <returns>The same <see cref="SprintBacklogItemQuery"/>, updated to include the "Sprint" sub-query.</returns>
        public SprintBacklogItemQuery SelectSprint(SprintQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("sprint", query, false);
        }
    }
}
