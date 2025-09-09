using System;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/shorturlupdateinput/">ShortUrlUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class ShortUrlUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private Uri? _uri;
        private string? _ciId;
        private string? _dashboardId;
        private string? _knowledgeArticleId;
        private string? _mapAddress;
        private string? _plainText;
        private string? _requestTemplateId;
        private string? _skypeName;
        private string? _tel;
        private string? _tweet;
        private string? _twitterName;
        private Uri? _websiteUrl;
        private ShortUrlEmailInput? _email;
        private ShortUrlGeoInput? _geo;
        private ShortUrlSmsInput? _sms;
        private string _id;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [XurrentField("clientMutationId")]
        public string? ClientMutationId
        {
            get => _clientMutationId;
            set => _clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// The uniform resource identifier (URI) to which the short URL is forwarded.
        /// </summary>
        [XurrentField("uri")]
        public Uri? Uri
        {
            get => _uri;
            set => _uri = Set("uri", value);
        }

        /// <summary>
        /// Identifier of the CI for which a request is to be registered in Xurrent Self Service when the short URL is used.
        /// </summary>
        [XurrentField("ciId")]
        public string? CiId
        {
            get => _ciId;
            set => _ciId = Set("ciId", value);
        }

        /// <summary>
        /// Identifier of the dashboard which is to be opened when the short URL is used.
        /// </summary>
        [XurrentField("dashboardId")]
        public string? DashboardId
        {
            get => _dashboardId;
            set => _dashboardId = Set("dashboardId", value);
        }

        /// <summary>
        /// Identifier of the knowledge article which instructions need to be displayed when the short URL is used in Xurrent Self Service.
        /// </summary>
        [XurrentField("knowledgeArticleId")]
        public string? KnowledgeArticleId
        {
            get => _knowledgeArticleId;
            set => _knowledgeArticleId = Set("knowledgeArticleId", value);
        }

        /// <summary>
        /// The address (or only the city or country) for which a map should be opened when the short URL is used.
        /// </summary>
        [XurrentField("mapAddress")]
        public string? MapAddress
        {
            get => _mapAddress;
            set => _mapAddress = Set("mapAddress", value);
        }

        /// <summary>
        /// The Plain text field is used to enter the text that should be displayed when the short URL is used.
        /// </summary>
        [XurrentField("plainText")]
        public string? PlainText
        {
            get => _plainText;
            set => _plainText = Set("plainText", value);
        }

        /// <summary>
        /// The identifier of the request template that is to be applied to each new request that is opened when in Xurrent Self Service when the short URL is used.
        /// </summary>
        [XurrentField("requestTemplateId")]
        public string? RequestTemplateId
        {
            get => _requestTemplateId;
            set => _requestTemplateId = Set("requestTemplateId", value);
        }

        /// <summary>
        /// The Skype name that is to be called when the short URL is used.
        /// </summary>
        [XurrentField("skypeName")]
        public string? SkypeName
        {
            get => _skypeName;
            set => _skypeName = Set("skypeName", value);
        }

        /// <summary>
        /// The telephone number that is to be called when the short URL is used.
        /// </summary>
        [XurrentField("tel")]
        public string? Tel
        {
            get => _tel;
            set => _tel = Set("tel", value);
        }

        /// <summary>
        /// The Twitter tweet that is to be generated when the short URL is used.
        /// </summary>
        [XurrentField("tweet")]
        public string? Tweet
        {
            get => _tweet;
            set => _tweet = Set("tweet", value);
        }

        /// <summary>
        /// The name of the Twitter user whose Twitter feed is to be opened when the short URL is used.
        /// </summary>
        [XurrentField("twitterName")]
        public string? TwitterName
        {
            get => _twitterName;
            set => _twitterName = Set("twitterName", value);
        }

        /// <summary>
        /// The uniform resource locator of a website to which the short URL is to forward when it is used.
        /// </summary>
        [XurrentField("websiteUrl")]
        public Uri? WebsiteUrl
        {
            get => _websiteUrl;
            set => _websiteUrl = Set("websiteUrl", value);
        }

        /// <summary>
        /// Values for email that is to be generated when the short URL is used.
        /// </summary>
        [XurrentField("email")]
        public ShortUrlEmailInput? Email
        {
            get => _email;
            set => _email = Set("email", value);
        }

        /// <summary>
        /// Coordinates of the location for which a map should be opened when the short URL is used.
        /// </summary>
        [XurrentField("geo")]
        public ShortUrlGeoInput? Geo
        {
            get => _geo;
            set => _geo = Set("geo", value);
        }

        /// <summary>
        /// Values for the SMS message that is to be generated when the short URL is used.
        /// </summary>
        [XurrentField("sms")]
        public ShortUrlSmsInput? Sms
        {
            get => _sms;
            set => _sms = Set("sms", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlUpdateInput"/> class without providing the required values.
        /// </summary>
        public ShortUrlUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortUrlUpdateInput"/> class.
        /// </summary>
        public ShortUrlUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
