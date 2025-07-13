using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="Product">Product</see> fields.
    /// </summary>
    public enum ProductField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The brand field.
        /// </summary>
        [XurrentEnum("brand")]
        Brand,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The custom fields field.
        /// </summary>
        [XurrentEnum("customFields")]
        CustomFields,

        /// <summary>
        /// The depreciation method field.
        /// </summary>
        [XurrentEnum("depreciationMethod")]
        DepreciationMethod,

        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The financial owner field.
        /// </summary>
        [XurrentEnum("financialOwner")]
        FinancialOwner,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The model field.
        /// </summary>
        [XurrentEnum("model")]
        Model,

        /// <summary>
        /// The name field.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// The picture uri field.
        /// </summary>
        [XurrentEnum("pictureUri")]
        PictureUri,

        /// <summary>
        /// The product category field.
        /// </summary>
        [XurrentEnum("productCategory")]
        ProductCategory,

        /// <summary>
        /// The product id field.
        /// </summary>
        [XurrentEnum("productID")]
        ProductID,

        /// <summary>
        /// The rate field.
        /// </summary>
        [XurrentEnum("rate")]
        Rate,

        /// <summary>
        /// The recurrence field.
        /// </summary>
        [XurrentEnum("recurrence")]
        Recurrence,

        /// <summary>
        /// The remarks field.
        /// </summary>
        [XurrentEnum("remarks")]
        Remarks,

        /// <summary>
        /// The rule set field.
        /// </summary>
        [XurrentEnum("ruleSet")]
        RuleSet,

        /// <summary>
        /// The salvage value field.
        /// </summary>
        [XurrentEnum("salvageValue")]
        SalvageValue,

        /// <summary>
        /// The salvage value currency field.
        /// </summary>
        [XurrentEnum("salvageValueCurrency")]
        SalvageValueCurrency,

        /// <summary>
        /// The service field.
        /// </summary>
        [XurrentEnum("service")]
        Service,

        /// <summary>
        /// The source field.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// The source id field.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// The supplier field.
        /// </summary>
        [XurrentEnum("supplier")]
        Supplier,

        /// <summary>
        /// The support team field.
        /// </summary>
        [XurrentEnum("supportTeam")]
        SupportTeam,

        /// <summary>
        /// The ui extension field.
        /// </summary>
        [XurrentEnum("uiExtension")]
        UiExtension,

        /// <summary>
        /// The updated at field.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt,

        /// <summary>
        /// The useful life field.
        /// </summary>
        [XurrentEnum("usefulLife")]
        UsefulLife,

        /// <summary>
        /// The workflow manager field.
        /// </summary>
        [XurrentEnum("workflowManager")]
        WorkflowManager,

        /// <summary>
        /// The workflow template field.
        /// </summary>
        [XurrentEnum("workflowTemplate")]
        WorkflowTemplate
    }
}
