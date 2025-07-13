using System;
using System.Collections.Generic;
using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/product/">Product</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("Product")]
    public sealed class Product : IDataItem, INode, IRecord
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [XurrentField("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The brand name is typically the name of the product's manufacturer.
        /// </summary>
        [XurrentField("brand")]
        public string? Brand { get; internal set; }

        [XurrentField("configurationItems")]
        internal PagedResponse<ConfigurationItem>? ConfigurationItemsCollection { get; set; }
        /// <summary>
        /// Configuration items of the product.
        /// </summary>
        public ReadOnlyDataCollection<ConfigurationItem>? ConfigurationItems { get => ConfigurationItemsCollection?.Data is null ? null : new ReadOnlyDataCollection<ConfigurationItem>(ConfigurationItemsCollection.Data); }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [XurrentField("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [XurrentField("customFields")]
        internal CustomFieldCollection? CustomFieldCollection { get; set; }
        /// <summary>
        /// Values of custom fields.
        /// </summary>
        public IReadOnlyCustomFieldCollection? CustomFields { get => CustomFieldCollection is null ? null : new ReadOnlyCustomFieldCollection(CustomFieldCollection); }

        [XurrentField("customFieldsAttachments")]
        internal PagedResponse<Attachment>? CustomFieldsAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? CustomFieldsAttachments { get => CustomFieldsAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(CustomFieldsAttachmentsCollection.Data); }

        /// <summary>
        /// Used to specify whether or not configuration items that are based on the product are typically depreciated and if so, which depreciation method is normally applied. Valid values are:<br />
        ///   • <c>not_depreciated</c>: Not Depreciated.<br />
        ///   • <c>double_declining_balance</c>: Double Declining Balance.<br />
        ///   • <c>reducing_balance</c>: Reducing Balance (or Diminishing Value).<br />
        ///   • <c>straight_line</c>: Straight Line (or Prime Cost).<br />
        ///   • <c>sum_of_the_years_digits</c>: Sum of the Year's Digits.<br />
        /// </summary>
        [XurrentField("depreciationMethod")]
        public ProductDepreciationMethod? DepreciationMethod { get; internal set; }

        /// <summary>
        /// Whether the product may no longer be used to register new configuration items.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The internal organization which budget is normally used to obtain the product.
        /// </summary>
        [XurrentField("financialOwner")]
        public Organization? FinancialOwner { get; internal set; }

        /// <summary>
        /// Unique identifier of the record.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The model of the product.
        /// </summary>
        [XurrentField("model")]
        public string? Model { get; internal set; }

        /// <summary>
        /// The name of the product. Fill out the Brand, Model, Product ID (optional) and Category fields to automatically generate a name based on the values entered in these fields.
        /// </summary>
        [XurrentField("name", IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [XurrentField("pictureUri")]
        public Uri? PictureUri { get; internal set; }

        /// <summary>
        /// The appropriate product category for the product.
        /// </summary>
        [XurrentField("productCategory")]
        public ProductCategory? ProductCategory { get; internal set; }

        /// <summary>
        /// The unique identifier of the product that is used by the manufacturer. The concatenation of <c>brand</c> and <c>productID</c> must be unique within a Xurrent account.
        /// </summary>
        [XurrentField("productID")]
        public string? ProductID { get; internal set; }

        /// <summary>
        /// The yearly rate that should normally be applied to calculate the depreciation of configuration items that are based on the product using the reducing balance (or diminishing value) method.
        /// </summary>
        [XurrentField("rate")]
        public long? Rate { get; internal set; }

        /// <summary>
        /// Recurrence for maintenance of configuration items created from the product.
        /// </summary>
        [XurrentField("recurrence")]
        public RecurrenceTemplate? Recurrence { get; internal set; }

        /// <summary>
        /// Any additional information about the product that might prove useful.
        /// </summary>
        [XurrentField("remarks")]
        public string? Remarks { get; internal set; }

        [XurrentField("remarksAttachments")]
        internal PagedResponse<Attachment>? RemarksAttachmentsCollection { get; set; }
        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        public ReadOnlyDataCollection<Attachment>? RemarksAttachments { get => RemarksAttachmentsCollection?.Data is null ? null : new ReadOnlyDataCollection<Attachment>(RemarksAttachmentsCollection.Data); }

        /// <summary>
        /// The rule set of the related product category.
        /// </summary>
        [XurrentField("ruleSet")]
        public ProductCategoryRuleSet? RuleSet { get; internal set; }

        /// <summary>
        /// The value of this product at the end of its useful life (i.e. at the end of its depreciation period). When a value is not specified for this field, it is set to zero.
        /// </summary>
        [XurrentField("salvageValue")]
        public decimal? SalvageValue { get; internal set; }

        /// <summary>
        /// The currency of the salvage value of this product.
        /// </summary>
        [XurrentField("salvageValueCurrency")]
        public Currency? SalvageValueCurrency { get; internal set; }

        /// <summary>
        /// The Service which Service Instances would typically include the product.
        /// </summary>
        [XurrentField("service")]
        public Service? Service { get; internal set; }

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
        /// The organization from which the product is typically obtained. If the product is developed internally, select the internal organization that develops it. Note that a lease company should be selected in this field if the product is normally leased.
        /// </summary>
        [XurrentField("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The team responsible for maintaining the product's information in the configuration management database (CMDB).
        /// </summary>
        [XurrentField("supportTeam")]
        public Team? SupportTeam { get; internal set; }

        /// <summary>
        /// UI extension that is to be added to the configuration items that are based on the product.
        /// </summary>
        [XurrentField("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [XurrentField("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The number of years within which configuration items that are based on the product are typically depreciated.
        /// </summary>
        [XurrentField("usefulLife")]
        public long? UsefulLife { get; internal set; }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        [XurrentField("workflowManager")]
        public Person? WorkflowManager { get; internal set; }

        /// <summary>
        /// The workflow template that is used to periodically maintain configuration items created from the product.
        /// </summary>
        [XurrentField("workflowTemplate")]
        public WorkflowTemplate? WorkflowTemplate { get; internal set; }

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
            if (data is Product product)
            {
                ConfigurationItemsCollection?.Data?.AddRange(product.ConfigurationItems);
                CustomFieldsAttachmentsCollection?.Data?.AddRange(product.CustomFieldsAttachments);
                RemarksAttachmentsCollection?.Data?.AddRange(product.RemarksAttachments);
            }
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            if (ConfigurationItemsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in ConfigurationItemsCollection.GetPageInfo("configurationItems", depth))
                    yield return pageInfo;

            if (CustomFieldsAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in CustomFieldsAttachmentsCollection.GetPageInfo("customFieldsAttachments", depth))
                    yield return pageInfo;

            if (RemarksAttachmentsCollection is not null)
                foreach (ExecutionPageInfo pageInfo in RemarksAttachmentsCollection.GetPageInfo("remarksAttachments", depth))
                    yield return pageInfo;
        }
    }
}
