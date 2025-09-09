using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/surveyanswerinput/">SurveyAnswerInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class SurveyAnswerInput : PropertyChangeSet
    {
        private string? _id;
        private string? _questionId;
        private string? _text;
        private int? _rating;

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
        /// Identifier of the question the answer is for.
        /// </summary>
        [XurrentField("questionId")]
        public string? QuestionId
        {
            get => _questionId;
            set => _questionId = Set("questionId", value);
        }

        /// <summary>
        /// Content of the answer for text questions.
        /// </summary>
        [XurrentField("text")]
        public string? Text
        {
            get => _text;
            set => _text = Set("text", value);
        }

        /// <summary>
        /// Content of the answer for rating questions.
        /// </summary>
        [XurrentField("rating")]
        public int? Rating
        {
            get => _rating;
            set => _rating = Set("rating", value);
        }
    }
}
