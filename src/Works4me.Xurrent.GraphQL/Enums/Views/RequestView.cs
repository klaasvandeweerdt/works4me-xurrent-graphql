using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Views on Requests.
    /// </summary>
    public enum RequestView
    {
        /// <summary>
        /// All Requests.
        /// </summary>
        [XurrentEnum("all")]
        All,

        /// <summary>
        /// Archived Requests.
        /// </summary>
        [XurrentEnum("archive")]
        Archive,

        /// <summary>
        /// Requests Assigned to Me.
        /// </summary>
        [XurrentEnum("assigned_to_me")]
        AssignedToMe,

        /// <summary>
        /// Requests Assigned to My Team.
        /// </summary>
        [XurrentEnum("assigned_to_my_team")]
        AssignedToMyTeam,

        /// <summary>
        /// Requests Assigned to Our Providers.
        /// </summary>
        [XurrentEnum("assigned_to_our_providers")]
        AssignedToOurProviders,

        /// <summary>
        /// Requests Created By Me.
        /// </summary>
        [XurrentEnum("created_by_me")]
        CreatedByMe,

        /// <summary>
        /// All Requests which account equals the value supplied via the <c>x-xurrent-account</c> header.
        /// </summary>
        [XurrentEnum("current_account")]
        CurrentAccount,

        /// <summary>
        /// Requests for Problem Identification.
        /// </summary>
        [XurrentEnum("problem_management_review")]
        ProblemManagementReview,

        /// <summary>
        /// Requests Requested By or For Me.
        /// </summary>
        [XurrentEnum("requested_by_or_for_me")]
        RequestedByOrForMe,

        /// <summary>
        /// Requests with Dissatisfied Requester.
        /// </summary>
        [XurrentEnum("requester_dissatisfied")]
        RequesterDissatisfied,

        /// <summary>
        /// Requests of My Organization (only for key contacts).
        /// </summary>
        [XurrentEnum("requests_of_my_organization")]
        RequestsOfMyOrganization,

        /// <summary>
        /// Requests My Team Is Accountable For.
        /// </summary>
        [XurrentEnum("sla_accountability")]
        SlaAccountability,

        /// <summary>
        /// Trashed Requests.
        /// </summary>
        [XurrentEnum("trash")]
        Trash
    }
}
