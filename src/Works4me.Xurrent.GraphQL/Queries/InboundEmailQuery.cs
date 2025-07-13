using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="InboundEmail"/> query class.
    /// </summary>
    public class InboundEmailQuery : Query<InboundEmail, InboundEmailQuery, DefaultView, InboundEmailField, DefaultFilterField, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="InboundEmailQuery"/> instance.
        /// </summary>
        public InboundEmailQuery() : base(string.Empty, false)
        {
        }

        /// <summary>
        /// The account that received the inbound email.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="InboundEmailQuery"/>, updated to include the "Account" sub-query.</returns>
        public InboundEmailQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The note that was created from the inbound email.
        /// </summary>
        /// <param name="query">The note query.</param>
        /// <returns>The same <see cref="InboundEmailQuery"/>, updated to include the "Note" sub-query.</returns>
        public InboundEmailQuery SelectNote(NoteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("note", query, false);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.<br />
        /// A new instance of the respective query type is created when the parameter is not provided or <c>null</c>.<br />
        /// </summary>
        /// <param name="problemQuery">The problem query.</param>
        /// <param name="projectQuery">The project query.</param>
        /// <param name="projectTaskQuery">The project task query.</param>
        /// <param name="releaseQuery">The release query.</param>
        /// <param name="requestQuery">The request query.</param>
        /// <param name="riskQuery">The risk query.</param>
        /// <param name="workflowTaskQuery">The workflow task query.</param>
        /// <param name="workflowQuery">The workflow query.</param>
        /// <returns>The same <see cref="InboundEmailQuery"/>, updated to include the sub-queries.</returns>
        public InboundEmailQuery SelectRecordAll(
            ProblemQuery? problemQuery = null,
            ProjectQuery? projectQuery = null,
            ProjectTaskQuery? projectTaskQuery = null,
            ReleaseQuery? releaseQuery = null,
            RequestQuery? requestQuery = null,
            RiskQuery? riskQuery = null,
            WorkflowTaskQuery? workflowTaskQuery = null,
            WorkflowQuery? workflowQuery = null)
        {
            InboundEmailQuery query = SelectOnType("record", problemQuery ?? new(), false);
            query = query.SelectOnType("record", projectQuery ?? new(), false);
            query = query.SelectOnType("record", projectTaskQuery ?? new(), false);
            query = query.SelectOnType("record", releaseQuery ?? new(), false);
            query = query.SelectOnType("record", requestQuery ?? new(), false);
            query = query.SelectOnType("record", riskQuery ?? new(), false);
            query = query.SelectOnType("record", workflowTaskQuery ?? new(), false);
            query = query.SelectOnType("record", workflowQuery ?? new(), false);
            return query;
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="InboundEmailQuery"/>, updated to include the "Record" sub-query.</returns>
        public InboundEmailQuery SelectRecord(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="InboundEmailQuery"/>, updated to include the "Record" sub-query.</returns>
        public InboundEmailQuery SelectRecord(ProjectQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="InboundEmailQuery"/>, updated to include the "Record" sub-query.</returns>
        public InboundEmailQuery SelectRecord(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="InboundEmailQuery"/>, updated to include the "Record" sub-query.</returns>
        public InboundEmailQuery SelectRecord(ReleaseQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="InboundEmailQuery"/>, updated to include the "Record" sub-query.</returns>
        public InboundEmailQuery SelectRecord(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="InboundEmailQuery"/>, updated to include the "Record" sub-query.</returns>
        public InboundEmailQuery SelectRecord(RiskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="InboundEmailQuery"/>, updated to include the "Record" sub-query.</returns>
        public InboundEmailQuery SelectRecord(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.<br />
        /// Use this method along with other <c>SelectRecord()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectRecord()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The record query.</param>
        /// <returns>The same <see cref="InboundEmailQuery"/>, updated to include the "Record" sub-query.</returns>
        public InboundEmailQuery SelectRecord(WorkflowQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("record", query, false);
        }
    }
}
