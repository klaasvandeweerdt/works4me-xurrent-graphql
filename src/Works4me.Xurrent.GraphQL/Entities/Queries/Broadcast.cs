using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/broadcast/">Broadcast</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Broadcast")]
    public sealed class Broadcast : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The body used in email broadcast.
        /// </summary>
        [XurrentField("body")]
        public string? Body { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        [XurrentField("customers")]
        internal PagedResponse<Organization>? CustomersCollection { get; set; }
        /// <summary>
        /// Used to select one or more customer organizations when the broadcast is to be displayed for the specialists of the account in requests that were received from the selected organizations. This field is available only when the "Specialists in requests from the following customers" visibility option is selected.
        /// </summary>
        public ReadOnlyDataCollection<Organization>? Customers { get => CustomersCollection?.Data is null ? null : new ReadOnlyDataCollection<Organization>(CustomersCollection.Data); }

        /// <summary>
        /// Whether the message should not be broadcasted.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The email template used for the email broadcast. This email template needs to be of the type Send Email from Broadcast.
        /// </summary>
        [XurrentField("emailTemplate")]
        public EmailTemplate? EmailTemplate { get; internal set; }

        /// <summary>
        /// Used to select the end date and time of the broadcast. This field is left empty when the message is to be broadcasted until the Disabled box is checked. (If the broadcast should end at midnight at the end of a day, specify 12:00am or 24:00.).
        /// </summary>
        [XurrentField("endAt")]
        public DateTime? EndAt { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// Used to select the appropriate icon for the message. The selected icon is displayed alongside the message when the broadcast is presented.
        /// </summary>
        [XurrentField("messageType")]
        public BroadcastMessageType? MessageType { get; internal set; }

        [XurrentField("organizations")]
        internal PagedResponse<Organization>? OrganizationsCollection { get; set; }
        /// <summary>
        /// Used to select the organizations, to which people belong, that need to see the broadcast.
        /// </summary>
        public ReadOnlyDataCollection<Organization>? Organizations { get => OrganizationsCollection?.Data is null ? null : new ReadOnlyDataCollection<Organization>(OrganizationsCollection.Data); }

        /// <summary>
        /// Any additional information about the broadcast that might prove useful.
        /// </summary>
        [XurrentField("remarks")]
        public string? Remarks { get; internal set; }

        [XurrentField("remarksAttachments")]
        internal PagedResponse<Attachment>? RemarksAttachmentsCollection { get; set; }
        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? RemarksAttachments { get => RemarksAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(RemarksAttachmentsCollection.Data); }

        /// <summary>
        /// Grouped request to which customers can add request to indicate they are also affected.
        /// </summary>
        [XurrentField("request")]
        public Request? Request { get; internal set; }

        [XurrentField("serviceInstances")]
        internal PagedResponse<ServiceInstance>? ServiceInstancesCollection { get; set; }
        /// <summary>
        /// Used to select the service instances for which the people, who are covered for them by an active SLA, need to see the broadcast. This table field is available only when the "People covered for the following service instance(s)" visibility option is selected.
        /// </summary>
        public ReadOnlyDataCollection<ServiceInstance>? ServiceInstances { get => ServiceInstancesCollection?.Data is null ? null : new ReadOnlyDataCollection<ServiceInstance>(ServiceInstancesCollection.Data); }

        [XurrentField("sites")]
        internal PagedResponse<Site>? SitesCollection { get; set; }
        /// <summary>
        /// Used to select the sites for which people need to see the broadcast.
        /// </summary>
        public ReadOnlyDataCollection<Site>? Sites { get => SitesCollection?.Data is null ? null : new ReadOnlyDataCollection<Site>(SitesCollection.Data); }

        [XurrentField("skillPools")]
        internal PagedResponse<SkillPool>? SkillPoolsCollection { get; set; }
        /// <summary>
        /// Used to select the skill pools, to which people belong, that need to see the broadcast.
        /// </summary>
        public ReadOnlyDataCollection<SkillPool>? SkillPools { get => SkillPoolsCollection?.Data is null ? null : new ReadOnlyDataCollection<SkillPool>(SkillPoolsCollection.Data); }

        [XurrentField("slas")]
        internal PagedResponse<ServiceLevelAgreement>? SlasCollection { get; set; }
        /// <summary>
        /// Used to select the service level agreements for which the customer representatives will receive the email broadcast. This is only available for broadcasts when the message type "email" is selected.
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
        /// Used to specify the start date and time of the broadcast. (If the broadcast should start at midnight at the start of a day, specify 00:00.).
        /// </summary>
        [XurrentField("startAt")]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// The subject used in email broadcasts.
        /// </summary>
        [XurrentField("subject", IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        [XurrentField("teams")]
        internal PagedResponse<Team>? TeamsCollection { get; set; }
        /// <summary>
        /// Used to select the teams which members need to see the broadcast. This table field is available only when the "Members of the following team(s)" visibility option is selected.
        /// </summary>
        public ReadOnlyDataCollection<Team>? Teams { get => TeamsCollection?.Data is null ? null : new ReadOnlyDataCollection<Team>(TeamsCollection.Data); }

        /// <summary>
        /// Used to select the time zone that applies to the dates and times specified in the Start and End fields.<br />
        /// The list with possible values is available on the <a href="https://developer.xurrent.com/graphql/scalar/timezone/">Xurrent developer site</a>.<br />
        /// </summary>
        [XurrentField("timeZone")]
        public string? TimeZone { get; internal set; }

        [XurrentField("translations")]
        internal PagedResponse<BroadcastTranslation>? TranslationsCollection { get; set; }
        /// <summary>
        /// Broadcast's message in different languages.
        /// </summary>
        public ReadOnlyDataCollection<BroadcastTranslation>? Translations { get => TranslationsCollection?.Data is null ? null : new ReadOnlyDataCollection<BroadcastTranslation>(TranslationsCollection.Data); }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Used to define the target audience of the broadcast.
        /// </summary>
        [XurrentField("visibility")]
        public BroadcastVisibility? Visibility { get; internal set; }

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
            if (data is Broadcast broadcast)
            {
                CustomersCollection?.Data?.AddRange(broadcast.Customers);
                OrganizationsCollection?.Data?.AddRange(broadcast.Organizations);
                RemarksAttachmentsCollection?.Data?.AddRange(broadcast.RemarksAttachments);
                ServiceInstancesCollection?.Data?.AddRange(broadcast.ServiceInstances);
                SitesCollection?.Data?.AddRange(broadcast.Sites);
                SkillPoolsCollection?.Data?.AddRange(broadcast.SkillPools);
                SlasCollection?.Data?.AddRange(broadcast.Slas);
                TeamsCollection?.Data?.AddRange(broadcast.Teams);
                TranslationsCollection?.Data?.AddRange(broadcast.Translations);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (CustomersCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomersCollection.GetPageInfo("customers", depth))
                    yield return pageInfo;

            if (OrganizationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in OrganizationsCollection.GetPageInfo("organizations", depth))
                    yield return pageInfo;

            if (RemarksAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RemarksAttachmentsCollection.GetPageInfo("remarksAttachments", depth))
                    yield return pageInfo;

            if (ServiceInstancesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ServiceInstancesCollection.GetPageInfo("serviceInstances", depth))
                    yield return pageInfo;

            if (SitesCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SitesCollection.GetPageInfo("sites", depth))
                    yield return pageInfo;

            if (SkillPoolsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SkillPoolsCollection.GetPageInfo("skillPools", depth))
                    yield return pageInfo;

            if (SlasCollection is not null)
                foreach (ExecutionPageInfo pageInfo in SlasCollection.GetPageInfo("slas", depth))
                    yield return pageInfo;

            if (TeamsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TeamsCollection.GetPageInfo("teams", depth))
                    yield return pageInfo;

            if (TranslationsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in TranslationsCollection.GetPageInfo("translations", depth))
                    yield return pageInfo;
        }
    }
}
