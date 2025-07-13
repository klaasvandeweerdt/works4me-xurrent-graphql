using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/surveyresponse/">SurveyResponse</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("SurveyResponse")]
    public sealed class SurveyResponse : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        [XurrentField("answers")]
        internal PagedResponse<SurveyAnswer>? AnswersCollection { get; set; }
        /// <summary>
        /// Answers of this survey response.
        /// </summary>
        public ReadOnlyDataCollection<SurveyAnswer>? Answers { get => AnswersCollection?.Data is null ? null : new ReadOnlyDataCollection<SurveyAnswer>(AnswersCollection.Data); }

        /// <summary>
        /// Whether the respondent completed the survey.
        /// </summary>
        [XurrentField("completed")]
        public bool? Completed { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Rating calculated based on the answers.
        /// </summary>
        [XurrentField("rating")]
        public int? Rating { get; internal set; }

        /// <summary>
        /// How the individual answers were combined to calculate the rating.
        /// </summary>
        [XurrentField("ratingCalculation")]
        public JsonElement? RatingCalculation { get; internal set; }

        /// <summary>
        /// Time this response was submitted.
        /// </summary>
        [XurrentField("respondedAt")]
        public DateTime? RespondedAt { get; internal set; }

        /// <summary>
        /// Service this response is about.
        /// </summary>
        [XurrentField("service")]
        public Service? Service { get; internal set; }

        [XurrentField("slas")]
        internal PagedResponse<ServiceLevelAgreement>? SlasCollection { get; set; }
        /// <summary>
        /// SLAs of this survey response.
        /// </summary>
        public ReadOnlyDataCollection<ServiceLevelAgreement>? Slas { get => SlasCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceLevelAgreement>(SlasCollection.Data); }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// Survey this response is for.
        /// </summary>
        [XurrentField("survey")]
        public Survey? Survey { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// <br>Returns a key used internally for merging paged or partial data responses within a <see cref="DataCollection{T}"/>.</br>
        /// <br>This key is not guaranteed to be unique outside the context of merging and should not be relied upon as a business identifier.</br>
        /// </summary>
        string IDataItem.GetMergeKey()
        {
            return Id;
        }

        /// <summary>
        /// <br>Merges connection data from the specified <paramref name="data"/> item into the current item.</br>
        /// <br>This method is intended for consolidating partial or paged results received from multiple responses.</br>
        /// </summary>
        /// <param name="data">The <see cref="IDataItem"/> instance whose connection data should be merged into the current item.</param>
        void IDataItem.MergeConnectionData(IDataItem data)
        {
            if (data is SurveyResponse surveyResponse)
            {
                AnswersCollection?.Data?.AddRange(surveyResponse.Answers);
                SlasCollection?.Data?.AddRange(surveyResponse.Slas);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (AnswersCollection is not null)
                foreach (ExecutionPageInfo pageInfo in AnswersCollection.GetPageInfo("answers", depth))
                    yield return pageInfo;

            if (SlasCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SlasCollection.GetPageInfo("slas", depth))
                    yield return pageInfo;
        }
    }
}
