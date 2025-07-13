using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/projecttemplate/">ProjectTemplate</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ProjectTemplate")]
    public sealed class ProjectTemplate : IDataItem, INode, IRecord
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
        /// Whether the project template may not be used to help register new projects.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        [XurrentField("phases")]
        internal PagedResponse<ProjectTemplatePhase>? PhasesCollection { get; set; }
        /// <summary>
        /// Phases of the project template.
        /// </summary>
        public ReadOnlyDataCollection<ProjectTemplatePhase>? Phases { get => PhasesCollection?.Data is null ? null : new ReadOnlyDataCollection<ProjectTemplatePhase>(PhasesCollection.Data); }

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
        /// A short description that needs to be copied to the Subject field of a new project when it is being created based on the template.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        [XurrentField("taskTemplateRelations")]
        internal PagedResponse<ProjectTaskTemplateRelation>? TaskTemplateRelationsCollection { get; set; }
        /// <summary>
        /// Task template relations of the project template.
        /// </summary>
        public ReadOnlyDataCollection<ProjectTaskTemplateRelation>? TaskTemplateRelations { get => TaskTemplateRelationsCollection?.Data is null ? null : new ReadOnlyDataCollection<ProjectTaskTemplateRelation>(TaskTemplateRelationsCollection.Data); }

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
            if (data is ProjectTemplate projectTemplate)
            {
                PhasesCollection?.Data?.AddRange(projectTemplate.Phases);
                TaskTemplateRelationsCollection?.Data?.AddRange(projectTemplate.TaskTemplateRelations);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (PhasesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in PhasesCollection.GetPageInfo("phases", depth))
                    yield return pageInfo;

            if (TaskTemplateRelationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TaskTemplateRelationsCollection.GetPageInfo("taskTemplateRelations", depth))
                    yield return pageInfo;
        }
    }
}
