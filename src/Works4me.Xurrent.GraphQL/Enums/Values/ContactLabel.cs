using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The contact label values.
    /// </summary>
    public enum ContactLabel
    {
        /// <summary>
        /// Skype.
        /// </summary>
        [XurrentEnum("chat_skype")]
        ChatSkype,

        /// <summary>
        /// Slack.
        /// </summary>
        [XurrentEnum("chat_slack")]
        ChatSlack,

        /// <summary>
        /// Teams.
        /// </summary>
        [XurrentEnum("chat_teams")]
        ChatTeams,

        /// <summary>
        /// Work chat.
        /// </summary>
        [XurrentEnum("chat_workchat")]
        ChatWorkchat,

        /// <summary>
        /// Emergency.
        /// </summary>
        [XurrentEnum("emergency")]
        Emergency,

        /// <summary>
        /// Fax.
        /// </summary>
        [XurrentEnum("fax")]
        Fax,

        /// <summary>
        /// General.
        /// </summary>
        [XurrentEnum("general")]
        General,

        /// <summary>
        /// Home.
        /// </summary>
        [XurrentEnum("home")]
        Home,

        /// <summary>
        /// Mobile.
        /// </summary>
        [XurrentEnum("mobile")]
        Mobile,

        /// <summary>
        /// Personal.
        /// </summary>
        [XurrentEnum("personal")]
        Personal,

        /// <summary>
        /// Service desk.
        /// </summary>
        [XurrentEnum("service_desk")]
        ServiceDesk,

        /// <summary>
        /// Service desk fax.
        /// </summary>
        [XurrentEnum("service_desk_fax")]
        ServiceDeskFax,

        /// <summary>
        /// Work.
        /// </summary>
        [XurrentEnum("work")]
        Work
    }
}
