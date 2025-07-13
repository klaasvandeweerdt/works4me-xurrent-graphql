using System;
using System.Collections.ObjectModel;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/surveyresponseupdateinput/">SurveyResponseUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class SurveyResponseUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private bool? _completed;
        private DateTime? _respondedAt;
        private string? _personId;
        private int? _rating;
        private JsonElement? _ratingCalculation;
        private string? _serviceId;
        private string? _surveyId;
        private Collection<string>? _slaIds;
        private Collection<SurveyAnswerInput>? _newAnswers;
        private string _id;
        private Collection<string>? _answersToDelete;

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
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Whether the respondent completed the survey.
        /// </summary>
        [XurrentField("completed")]
        public bool? Completed
        {
            get => _completed;
            set => _completed = Set("completed", value);
        }

        /// <summary>
        /// Time this response was submitted.
        /// </summary>
        [XurrentField("respondedAt")]
        public DateTime? RespondedAt
        {
            get => _respondedAt;
            set => _respondedAt = Set("respondedAt", value);
        }

        /// <summary>
        /// Identifier of the person who provided this response (i.e. the respondent).
        /// </summary>
        [XurrentField("personId")]
        public string? PersonId
        {
            get => _personId;
            set => _personId = Set("personId", value);
        }

        /// <summary>
        /// Rating calculated based on the answers.
        /// </summary>
        [XurrentField("rating")]
        public int? Rating
        {
            get => _rating;
            set => _rating = Set("rating", value);
        }

        /// <summary>
        /// How the individual answers were combined to calculate the rating.
        /// </summary>
        [XurrentField("ratingCalculation")]
        public JsonElement? RatingCalculation
        {
            get => _ratingCalculation;
            set => _ratingCalculation = Set("ratingCalculation", value);
        }

        /// <summary>
        /// Identifier of the service this response is about.
        /// </summary>
        [XurrentField("serviceId")]
        public string? ServiceId
        {
            get => _serviceId;
            set => _serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Identifier of the survey this response is for.
        /// </summary>
        [XurrentField("surveyId")]
        public string? SurveyId
        {
            get => _surveyId;
            set => _surveyId = Set("surveyId", value);
        }

        /// <summary>
        /// Identifiers of the SLAs this response is for. (Ignored when supplying a personId.).
        /// </summary>
        [XurrentField("slaIds")]
        public Collection<string>? SlaIds
        {
            get => _slaIds;
            set => _slaIds = Set("slaIds", value);
        }

        /// <summary>
        /// Answers of this survey response.
        /// </summary>
        [XurrentField("newAnswers")]
        public Collection<SurveyAnswerInput>? NewAnswers
        {
            get => _newAnswers;
            set => _newAnswers = Set("newAnswers", value);
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
        /// Identifiers of answers to remove from the survey.
        /// </summary>
        [XurrentField("answersToDelete")]
        public Collection<string>? AnswersToDelete
        {
            get => _answersToDelete;
            set => _answersToDelete = Set("answersToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyResponseUpdateInput"/> class without providing the required values.
        /// </summary>
        public SurveyResponseUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyResponseUpdateInput"/> class.
        /// </summary>
        public SurveyResponseUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
