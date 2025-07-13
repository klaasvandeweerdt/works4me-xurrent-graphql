using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/surveyquestioninput/">SurveyQuestionInput</see> in Xurrent.
    /// </summary>
    public sealed class SurveyQuestionInput : PropertyChangeSet
    {
        private string? _id;
        private bool? _disabled;
        private SurveyQuestionType? _type;
        private string? _question;
        private string? _guidance;
        private long? _position;
        private bool? _required;
        private long? _weight;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [XurrentField("id")]
        public string? Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Whether the question should not be shown to respondents.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Type of the question.
        /// </summary>
        [XurrentField("type")]
        public SurveyQuestionType? Type
        {
            get => _type;
            set => _type = Set("type", value);
        }

        /// <summary>
        /// Question to pose.
        /// </summary>
        [XurrentField("question")]
        public string? Question
        {
            get => _question;
            set => _question = Set("question", value);
        }

        /// <summary>
        /// Additional information to aid in answering the question.
        /// </summary>
        [XurrentField("guidance")]
        public string? Guidance
        {
            get => _guidance;
            set => _guidance = Set("guidance", value);
        }

        /// <summary>
        /// Relative position of the question.
        /// </summary>
        [XurrentField("position")]
        public long? Position
        {
            get => _position;
            set => _position = Set("position", value);
        }

        /// <summary>
        /// Whether an answer to the question is required to completed the survey.
        /// </summary>
        [XurrentField("required")]
        public bool? Required
        {
            get => _required;
            set => _required = Set("required", value);
        }

        /// <summary>
        /// Relative weight of the question.
        /// </summary>
        [XurrentField("weight")]
        public long? Weight
        {
            get => _weight;
            set => _weight = Set("weight", value);
        }
    }
}
