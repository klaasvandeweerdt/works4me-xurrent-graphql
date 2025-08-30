using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Trash"/> query class.
    /// </summary>
    public class TrashQuery : Query<Trash, TrashQuery, TrashView, TrashField, TrashFilterField, TrashOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="TrashQuery"/> instance.
        /// </summary>
        public TrashQuery() : base("trash", true)
        {
        }

        /// <summary>
        /// The account of the trashed record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Account" sub-query.</returns>
        public TrashQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
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
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the sub-queries.</returns>
        public TrashQuery SelectTrashedAll(
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
            TrashQuery query = SelectOnType("trashed", configurationItemQuery ?? new(), false);
            query = query.SelectOnType("trashed", personQuery ?? new(), false);
            query = query.SelectOnType("trashed", problemQuery ?? new(), false);
            query = query.SelectOnType("trashed", projectQuery ?? new(), false);
            query = query.SelectOnType("trashed", projectTaskQuery ?? new(), false);
            query = query.SelectOnType("trashed", releaseQuery ?? new(), false);
            query = query.SelectOnType("trashed", requestQuery ?? new(), false);
            query = query.SelectOnType("trashed", riskQuery ?? new(), false);
            query = query.SelectOnType("trashed", shopOrderLineQuery ?? new(), false);
            query = query.SelectOnType("trashed", workflowTaskQuery ?? new(), false);
            query = query.SelectOnType("trashed", timeEntryQuery ?? new(), false);
            query = query.SelectOnType("trashed", workflowQuery ?? new(), false);
            return query;
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(ConfigurationItemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(ProjectQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(ReleaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(RiskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(ShopOrderLineQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(TimeEntryQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The trashed record, e.g. Request.<br />
        /// Use this method along with other <c>SelectTrashed()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectTrashed()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The trashed query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "Trashed" sub-query.</returns>
        public TrashQuery SelectTrashed(WorkflowQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("trashed", query, false);
        }

        /// <summary>
        /// The person who trashed the record.
        /// </summary>
        /// <param name="query">The trashed by query.</param>
        /// <returns>The same <see cref="TrashQuery"/>, updated to include the "TrashedBy" sub-query.</returns>
        public TrashQuery SelectTrashedBy(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("trashedBy", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="TrashQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="TrashQuery">TrashQuery</see>, updated to include the "Search" sub-query.</returns>
        public TrashQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
