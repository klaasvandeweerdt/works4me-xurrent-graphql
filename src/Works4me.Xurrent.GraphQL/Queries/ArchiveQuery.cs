using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Archive"/> query class.
    /// </summary>
    public class ArchiveQuery : Query<Archive, ArchiveQuery, ArchiveView, ArchiveField, ArchiveFilterField, ArchiveOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="ArchiveQuery"/> instance.
        /// </summary>
        public ArchiveQuery() : base("archive", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Account" sub-query.</returns>
        public ArchiveQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// A new instance of the respective query type is created when the parameter is not provided or <c>null</c>.<br />
        /// </summary>
        /// <param name="configurationItemQuery">The configuration item query.</param>
        /// <param name="personQuery">The person query.</param>
        /// <param name="problemQuery">The problem query.</param>
        /// <param name="projectQuery">The project query.</param>
        /// <param name="projectTaskQuery">The project task query.</param>
        /// <param name="releaseQuery">The release query.</param>
        /// <param name="requestQuery">The request query.</param>
        /// <param name="riskQuery">The risk query.</param>
        /// <param name="shopOrderLineQuery">The shop order line query.</param>
        /// <param name="workflowTaskQuery">The workflow task query.</param>
        /// <param name="timeEntryQuery">The time entry query.</param>
        /// <param name="workflowQuery">The workflow query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the sub-queries.</returns>
        public ArchiveQuery SelectArchivedAll(
            ConfigurationItemQuery? configurationItemQuery = null,
            PersonQuery? personQuery = null,
            ProblemQuery? problemQuery = null,
            ProjectQuery? projectQuery = null,
            ProjectTaskQuery? projectTaskQuery = null,
            ReleaseQuery? releaseQuery = null,
            RequestQuery? requestQuery = null,
            RiskQuery? riskQuery = null,
            ShopOrderLineQuery? shopOrderLineQuery = null,
            WorkflowTaskQuery? workflowTaskQuery = null,
            TimeEntryQuery? timeEntryQuery = null,
            WorkflowQuery? workflowQuery = null)
        {
            ArchiveQuery query = SelectOnType("archived", configurationItemQuery ?? new(), false);
            query = query.SelectOnType("archived", personQuery ?? new(), false);
            query = query.SelectOnType("archived", problemQuery ?? new(), false);
            query = query.SelectOnType("archived", projectQuery ?? new(), false);
            query = query.SelectOnType("archived", projectTaskQuery ?? new(), false);
            query = query.SelectOnType("archived", releaseQuery ?? new(), false);
            query = query.SelectOnType("archived", requestQuery ?? new(), false);
            query = query.SelectOnType("archived", riskQuery ?? new(), false);
            query = query.SelectOnType("archived", shopOrderLineQuery ?? new(), false);
            query = query.SelectOnType("archived", workflowTaskQuery ?? new(), false);
            query = query.SelectOnType("archived", timeEntryQuery ?? new(), false);
            query = query.SelectOnType("archived", workflowQuery ?? new(), false);
            return query;
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(ProjectQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(ReleaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(RiskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(ShopOrderLineQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(TimeEntryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The archived record.<br />
        /// Use this method along with other <c>SelectArchived()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectArchived()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The archived query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "Archived" sub-query.</returns>
        public ArchiveQuery SelectArchived(WorkflowQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("archived", query, false);
        }

        /// <summary>
        /// The person who archived the record.
        /// </summary>
        /// <param name="query">The archived by query.</param>
        /// <returns>The same <see cref="ArchiveQuery"/>, updated to include the "ArchivedBy" sub-query.</returns>
        public ArchiveQuery SelectArchivedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("archivedBy", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="ArchiveQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="ArchiveQuery">ArchiveQuery</see>, updated to include the "Search" sub-query.</returns>
        public ArchiveQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
