using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/surveyupdateinput/">SurveyUpdateInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class SurveyUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private Uri? _pictureUri;
        private bool? _disabled;
        private string? _name;
        private Collection<SurveyQuestionInput>? _newQuestions;
        private string _id;
        private Collection<string>? _questionsToDelete;

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
        /// The hyperlink to the image file for the record. This may be a <a href="https://developer.mozilla.org/en-US/docs/Web/URI/Reference/Schemes/data">'data URL'</a>, allowing the image to be supplied directly without requiring a separate upload first.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri
        {
            get => _pictureUri;
            set => _pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// Whether the survey may not be used.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Name of the survey.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Questions of this survey.
        /// </summary>
        [XurrentField("newQuestions")]
        public Collection<SurveyQuestionInput>? NewQuestions
        {
            get => _newQuestions;
            set => _newQuestions = Set("newQuestions", value);
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
        /// Identifiers of questions to remove from the survey.
        /// </summary>
        [XurrentField("questionsToDelete")]
        public Collection<string>? QuestionsToDelete
        {
            get => _questionsToDelete;
            set => _questionsToDelete = Set("questionsToDelete", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyUpdateInput"/> class without providing the required values.
        /// </summary>
        public SurveyUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyUpdateInput"/> class.
        /// </summary>
        public SurveyUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
