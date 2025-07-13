using System;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="TimeEntry"/> query class.
    /// </summary>
    public class TimeEntryQuery : Query<TimeEntry, TimeEntryQuery, TimeEntryView, TimeEntryField, TimeEntryFilterField, TimeEntryOrderField>
    {
        /// <summary>
        /// Initialize a new <see cref="TimeEntryQuery"/> instance.
        /// </summary>
        public TimeEntryQuery() : base("timeEntries", true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "Account" sub-query.</returns>
        public TimeEntryQuery SelectAccount(AccountQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("account", query, false);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.<br />
        /// A new instance of the respective query type is created when the parameter is not provided or <c>null</c>.<br />
        /// </summary>
        /// <param name="problemQuery">The problem query.</param>
        /// <param name="projectTaskQuery">The project task query.</param>
        /// <param name="requestQuery">The request query.</param>
        /// <param name="workflowTaskQuery">The workflow task query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the sub-queries.</returns>
        public TimeEntryQuery SelectAssignmentAll(
            ProblemQuery? problemQuery = null,
            ProjectTaskQuery? projectTaskQuery = null,
            RequestQuery? requestQuery = null,
            WorkflowTaskQuery? workflowTaskQuery = null)
        {
            TimeEntryQuery query = SelectOnType("assignment", problemQuery ?? new(), false);
            query = query.SelectOnType("assignment", projectTaskQuery ?? new(), false);
            query = query.SelectOnType("assignment", requestQuery ?? new(), false);
            query = query.SelectOnType("assignment", workflowTaskQuery ?? new(), false);
            return query;
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.<br />
        /// Use this method along with other <c>SelectAssignment()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectAssignment()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The assignment query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "Assignment" sub-query.</returns>
        public TimeEntryQuery SelectAssignment(ProblemQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("assignment", query, false);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.<br />
        /// Use this method along with other <c>SelectAssignment()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectAssignment()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The assignment query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "Assignment" sub-query.</returns>
        public TimeEntryQuery SelectAssignment(ProjectTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("assignment", query, false);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.<br />
        /// Use this method along with other <c>SelectAssignment()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectAssignment()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The assignment query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "Assignment" sub-query.</returns>
        public TimeEntryQuery SelectAssignment(RequestQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("assignment", query, false);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.<br />
        /// Use this method along with other <c>SelectAssignment()</c> calls to cast different object types.<br />
        /// If a specific type is not queried via <c>SelectAssignment()</c>, it defaults to a <c>null</c> value.<br />
        /// </summary>
        /// <param name="query">The assignment query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "Assignment" sub-query.</returns>
        public TimeEntryQuery SelectAssignment(WorkflowTaskQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return SelectOnType("assignment", query, false);
        }

        /// <summary>
        /// The organization for which the time was spent.
        /// </summary>
        /// <param name="query">The customer query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "Customer" sub-query.</returns>
        public TimeEntryQuery SelectCustomer(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("customer", query, false);
        }

        /// <summary>
        /// The effort class that best reflects the type of effort for which time spent is being registered.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "EffortClass" sub-query.</returns>
        public TimeEntryQuery SelectEffortClass(EffortClassQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("effortClass", query, false);
        }

        /// <summary>
        /// The note the time entry is linked to.
        /// </summary>
        /// <param name="query">The note query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "Note" sub-query.</returns>
        public TimeEntryQuery SelectNote(NoteQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("note", query, false);
        }

        /// <summary>
        /// The organization to which the person was linked when the time entry was created.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "Organization" sub-query.</returns>
        public TimeEntryQuery SelectOrganization(OrganizationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("organization", query, false);
        }

        /// <summary>
        /// The person who spent the time.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "Person" sub-query.</returns>
        public TimeEntryQuery SelectPerson(PersonQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("person", query, false);
        }

        /// <summary>
        /// The service for which the time was spent.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "Service" sub-query.</returns>
        public TimeEntryQuery SelectService(ServiceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("service", query, false);
        }

        /// <summary>
        /// The service instance for which the time was spent. This field is automatically set when a time entry is created for a request.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "ServiceInstance" sub-query.</returns>
        public TimeEntryQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceInstance", query, false);
        }

        /// <summary>
        /// The service level agreement for which the time was spent. This field is automatically set when a time entry is created for a request.
        /// </summary>
        /// <param name="query">The service level agreement query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "ServiceLevelAgreement" sub-query.</returns>
        public TimeEntryQuery SelectServiceLevelAgreement(ServiceLevelAgreementQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("serviceLevelAgreement", query, false);
        }

        /// <summary>
        /// Team the person of the time entry was a member of while the work was performed.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "Team" sub-query.</returns>
        public TimeEntryQuery SelectTeam(TeamQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("team", query, false);
        }

        /// <summary>
        /// The time allocation on which the time was spent. Only the time allocations that are linked to the person’s organization can be selected.
        /// </summary>
        /// <param name="query">The time allocation query.</param>
        /// <returns>The same <see cref="TimeEntryQuery"/>, updated to include the "TimeAllocation" sub-query.</returns>
        public TimeEntryQuery SelectTimeAllocation(TimeAllocationQuery query)
        {
            if (query is null)
                throw new ArgumentNullException(nameof(query));

            return Select("timeAllocation", query, false);
        }

        /// <summary>
        /// Adds a free-form search filter to this <see cref="TimeEntryQuery"/>.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The same <see cref="TimeEntryQuery">TimeEntryQuery</see>, updated to include the "QueryFilter" sub-query.</returns>
        public TimeEntryQuery Search(string value)
        {
            return AddQueryFilter(value);
        }
    }
}
