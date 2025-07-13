using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/survey/">Survey</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Survey")]
    public sealed class Survey : IDataItem, IHasTranslations, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Content shown to respondents on completion of the survey.
        /// </summary>
        [XurrentField("completion")]
        public string? Completion { get; internal set; }

        [XurrentField("completionAttachments")]
        internal PagedResponse<Attachment>? CompletionAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Completion field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? CompletionAttachments { get => CompletionAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(CompletionAttachmentsCollection.Data); }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the survey may not be used.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Introduction content of the survey.
        /// </summary>
        [XurrentField("introduction")]
        public string? Introduction { get; internal set; }

        [XurrentField("introductionAttachments")]
        internal PagedResponse<Attachment>? IntroductionAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Introduction field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? IntroductionAttachments { get => IntroductionAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(IntroductionAttachmentsCollection.Data); }

        /// <summary>
        /// Name of the survey.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        [XurrentField("questions")]
        internal PagedResponse<SurveyQuestion>? QuestionsCollection { get; set; }
        /// <summary>
        /// Questions of this survey.
        /// </summary>
        public ReadOnlyDataCollection<SurveyQuestion>? Questions { get => QuestionsCollection?.Data is null ? null : new ReadOnlyDataCollection<SurveyQuestion>(QuestionsCollection.Data); }

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

        [XurrentField("translations")]
        internal PagedResponse<Translation>? TranslationsCollection { get; set; }
        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ReadOnlyDataCollection<Translation>? Translations { get => TranslationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Translation>(TranslationsCollection.Data); }

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
            if (data is Survey survey)
            {
                CompletionAttachmentsCollection?.Data?.AddRange(survey.CompletionAttachments);
                IntroductionAttachmentsCollection?.Data?.AddRange(survey.IntroductionAttachments);
                QuestionsCollection?.Data?.AddRange(survey.Questions);
                TranslationsCollection?.Data?.AddRange(survey.Translations);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (CompletionAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CompletionAttachmentsCollection.GetPageInfo("completionAttachments", depth))
                    yield return pageInfo;

            if (IntroductionAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in IntroductionAttachmentsCollection.GetPageInfo("introductionAttachments", depth))
                    yield return pageInfo;

            if (QuestionsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in QuestionsCollection.GetPageInfo("questions", depth))
                    yield return pageInfo;

            if (TranslationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TranslationsCollection.GetPageInfo("translations", depth))
                    yield return pageInfo;
        }
    }
}
