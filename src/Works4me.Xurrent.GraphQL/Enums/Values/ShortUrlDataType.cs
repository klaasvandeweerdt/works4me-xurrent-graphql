using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The short url data type values.
    /// </summary>
    public enum ShortUrlDataType
    {
        /// <summary>
        /// Change calendar.
        /// </summary>
        [XurrentEnum("change_calendar_personal_view")]
        ChangeCalendarPersonalView,

        /// <summary>
        /// Configuration item in self service.
        /// </summary>
        [XurrentEnum("ci")]
        Ci,

        /// <summary>
        /// Dashboard.
        /// </summary>
        [XurrentEnum("dashboard")]
        Dashboard,

        /// <summary>
        /// Knowledge article in self service.
        /// </summary>
        [XurrentEnum("knowledge_article")]
        KnowledgeArticle,

        /// <summary>
        /// Email.
        /// </summary>
        [XurrentEnum("mailto")]
        Mailto,

        /// <summary>
        /// Map.
        /// </summary>
        [XurrentEnum("map")]
        Map,

        /// <summary>
        /// Media file in media library.
        /// </summary>
        [XurrentEnum("media_file")]
        MediaFile,

        /// <summary>
        /// Request template in self service.
        /// </summary>
        [XurrentEnum("request_template")]
        RequestTemplate,

        /// <summary>
        /// Service survey in self service.
        /// </summary>
        [XurrentEnum("service_survey")]
        ServiceSurvey,

        /// <summary>
        /// Skype.
        /// </summary>
        [XurrentEnum("skype")]
        Skype,

        /// <summary>
        /// Sms message.
        /// </summary>
        [XurrentEnum("sms")]
        Sms,

        /// <summary>
        /// Telephone number.
        /// </summary>
        [XurrentEnum("tel")]
        Tel,

        /// <summary>
        /// Plain text.
        /// </summary>
        [XurrentEnum("text")]
        Text,

        /// <summary>
        /// Tweet.
        /// </summary>
        [XurrentEnum("tweet")]
        Tweet,

        /// <summary>
        /// Twitter.
        /// </summary>
        [XurrentEnum("twitter")]
        Twitter,

        /// <summary>
        /// Uri.
        /// </summary>
        [XurrentEnum("uri")]
        Uri,

        /// <summary>
        /// Website address.
        /// </summary>
        [XurrentEnum("url")]
        Url
    }
}
