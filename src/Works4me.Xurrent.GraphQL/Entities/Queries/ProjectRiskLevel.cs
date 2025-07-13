using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projectrisklevel/">ProjectRiskLevel</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ProjectRiskLevel")]
    public sealed class ProjectRiskLevel : IDataItem, INode, IRecord
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
        /// A very short description of the project risk level, for example "Risk of Failure is Significant".
        /// </summary>
        [XurrentField("description")]
        public string? Description { get; internal set; }

        /// <summary>
        /// Whether the project risk level may not be related to any more projects.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Any additional information about the project risk level that might prove useful, especially for project managers when they need to decide which project risk level to select for a project.
        /// </summary>
        [XurrentField("information")]
        public string? Information { get; internal set; }

        [XurrentField("informationAttachments")]
        internal PagedResponse<Attachment>? InformationAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? InformationAttachments { get => InformationAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(InformationAttachmentsCollection.Data); }

        /// <summary>
        /// The name of the project risk level. Ideally the name of a project risk level consists of a single word, such as "Significant".
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The position that the project risk level takes when it is displayed in a sorted list.
        /// </summary>
        [XurrentField("position")]
        public long? Position { get; internal set; }

        /// <summary>
        /// The Reference field is automatically set to the Name field value, written in lower case characters and with all spaces replaced by the underscore character. This reference can be used to link the project risk level to a project using the Xurrent REST API or the Xurrent Import functionality.
        /// </summary>
        [XurrentField("reference")]
        public string? Reference { get; internal set; }

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
            if (data is ProjectRiskLevel projectRiskLevel)
            {
                InformationAttachmentsCollection?.Data?.AddRange(projectRiskLevel.InformationAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (InformationAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in InformationAttachmentsCollection.GetPageInfo("informationAttachments", depth))
                    yield return pageInfo;
        }
    }
}
