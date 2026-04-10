using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The request action type values.
    /// </summary>
    public enum RequestActionType
    {
        /// <summary>
        /// Access grant or revoke access rights.
        /// </summary>
        [XurrentEnum("access")]
        Access,

        /// <summary>
        /// Compliance ensure policy or regulatory adherence.
        /// </summary>
        [XurrentEnum("compliance")]
        Compliance,

        /// <summary>
        /// Configuration adjust settings or parameters.
        /// </summary>
        [XurrentEnum("configuration")]
        Configuration,

        /// <summary>
        /// Creation create something new.
        /// </summary>
        [XurrentEnum("creation")]
        Creation,

        /// <summary>
        /// Information provide information or guidance.
        /// </summary>
        [XurrentEnum("information")]
        Information,

        /// <summary>
        /// Installation install new software or hardware.
        /// </summary>
        [XurrentEnum("installation")]
        Installation,

        /// <summary>
        /// Modification change an existing item.
        /// </summary>
        [XurrentEnum("modification")]
        Modification,

        /// <summary>
        /// Offboarding deprovision a user or service.
        /// </summary>
        [XurrentEnum("offboarding")]
        Offboarding,

        /// <summary>
        /// Onboarding set up a new user or service.
        /// </summary>
        [XurrentEnum("onboarding")]
        Onboarding,

        /// <summary>
        /// Other action not covered above.
        /// </summary>
        [XurrentEnum("other")]
        Other,

        /// <summary>
        /// Procurement purchase or acquire an item.
        /// </summary>
        [XurrentEnum("procurement")]
        Procurement,

        /// <summary>
        /// Relocation move to a different location.
        /// </summary>
        [XurrentEnum("relocation")]
        Relocation,

        /// <summary>
        /// Removal remove or delete an item.
        /// </summary>
        [XurrentEnum("removal")]
        Removal,

        /// <summary>
        /// Renewal renew a license or subscription.
        /// </summary>
        [XurrentEnum("renewal")]
        Renewal,

        /// <summary>
        /// Replacement swap an item for another.
        /// </summary>
        [XurrentEnum("replacement")]
        Replacement,

        /// <summary>
        /// Reporting generate or deliver a report.
        /// </summary>
        [XurrentEnum("reporting")]
        Reporting,

        /// <summary>
        /// Reset reset a password or service state.
        /// </summary>
        [XurrentEnum("reset")]
        Reset,

        /// <summary>
        /// Restoration restore to a previous state.
        /// </summary>
        [XurrentEnum("restoration")]
        Restoration,

        /// <summary>
        /// Scheduling schedule or reschedule an activity.
        /// </summary>
        [XurrentEnum("scheduling")]
        Scheduling,

        /// <summary>
        /// Training request training or enablement.
        /// </summary>
        [XurrentEnum("training")]
        Training,

        /// <summary>
        /// Transfer reassign ownership or responsibility.
        /// </summary>
        [XurrentEnum("transfer")]
        Transfer,

        /// <summary>
        /// Troubleshoot diagnose and resolve an issue.
        /// </summary>
        [XurrentEnum("troubleshoot")]
        Troubleshoot,

        /// <summary>
        /// Upgrade upgrade to a newer version.
        /// </summary>
        [XurrentEnum("upgrade")]
        Upgrade
    }
}
