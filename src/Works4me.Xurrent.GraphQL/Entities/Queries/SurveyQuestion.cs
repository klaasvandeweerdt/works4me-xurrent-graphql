using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/surveyquestion/">SurveyQuestion</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("SurveyQuestion")]
    public sealed class SurveyQuestion : IDataItem, IHasTranslations, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the question should not be shown to respondents.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Additional information to aid in answering the question.
        /// </summary>
        [XurrentField("guidance")]
        public string? Guidance { get; internal set; }

        [XurrentField("guidanceAttachments")]
        internal PagedResponse<Attachment>? GuidanceAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Guidance field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? GuidanceAttachments { get => GuidanceAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(GuidanceAttachmentsCollection.Data); }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Relative position of the question.
        /// </summary>
        [XurrentField("position")]
        public long? Position { get; internal set; }

        /// <summary>
        /// Question to pose.
        /// </summary>
        [XurrentField("question")]
        public string? Question { get; internal set; }

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
        /// Survey the question is part of.
        /// </summary>
        [XurrentField("survey")]
        public Survey? Survey { get; internal set; }

        [XurrentField("translations")]
        internal PagedResponse<Translation>? TranslationsCollection { get; set; }
        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<Translation>? Translations { get => TranslationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Translation>(TranslationsCollection.Data); }

        /// <summary>
        /// Type of question.
        /// </summary>
        [XurrentField("type")]
        public SurveyQuestionType? Type { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Relative weight of the question.
        /// </summary>
        [XurrentField("weight")]
        public long? Weight { get; internal set; }

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
            if (data is SurveyQuestion surveyQuestion)
            {
                GuidanceAttachmentsCollection?.Data?.AddRange(surveyQuestion.GuidanceAttachments);
                TranslationsCollection?.Data?.AddRange(surveyQuestion.Translations);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (GuidanceAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in GuidanceAttachmentsCollection.GetPageInfo("guidanceAttachments", depth))
                    yield return pageInfo;

            if (TranslationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TranslationsCollection.GetPageInfo("translations", depth))
                    yield return pageInfo;
        }
    }
}
