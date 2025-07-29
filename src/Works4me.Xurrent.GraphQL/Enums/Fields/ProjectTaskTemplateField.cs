﻿using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The <see cref="ProjectTaskTemplate">ProjectTaskTemplate</see> fields.
    /// </summary>
    public enum ProjectTaskTemplateField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [XurrentEnum("account")]
        Account,

        /// <summary>
        /// The agile board field.
        /// </summary>
        [XurrentEnum("agileBoard")]
        AgileBoard,

        /// <summary>
        /// The agile board column field.
        /// </summary>
        [XurrentEnum("agileBoardColumn")]
        AgileBoardColumn,

        /// <summary>
        /// The assign to project manager field.
        /// </summary>
        [XurrentEnum("assignToProjectManager")]
        AssignToProjectManager,

        /// <summary>
        /// The assign to requester field.
        /// </summary>
        [XurrentEnum("assignToRequester")]
        AssignToRequester,

        /// <summary>
        /// The assign to requester business unit manager field.
        /// </summary>
        [XurrentEnum("assignToRequesterBusinessUnitManager")]
        AssignToRequesterBusinessUnitManager,

        /// <summary>
        /// The assign to requester manager field.
        /// </summary>
        [XurrentEnum("assignToRequesterManager")]
        AssignToRequesterManager,

        /// <summary>
        /// The assign to service owner field.
        /// </summary>
        [XurrentEnum("assignToServiceOwner")]
        AssignToServiceOwner,

        /// <summary>
        /// The category field.
        /// </summary>
        [XurrentEnum("category")]
        Category,

        /// <summary>
        /// The copy notes to project field.
        /// </summary>
        [XurrentEnum("copyNotesToProject")]
        CopyNotesToProject,

        /// <summary>
        /// The created at field.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// The disabled field.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// The effort class field.
        /// </summary>
        [XurrentEnum("effortClass")]
        EffortClass,

        /// <summary>
        /// The id field.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// The instructions field.
        /// </summary>
        [XurrentEnum("instructions")]
        Instructions,

        /// <summary>
        /// The note field.
        /// </summary>
        [XurrentEnum("note")]
        Note,

        /// <summary>
        /// The note behavior field.
        /// </summary>
        [XurrentEnum("noteBehavior")]
        NoteBehavior,

        /// <summary>
        /// The pdf design field.
        /// </summary>
        [XurrentEnum("pdfDesign")]
        PdfDesign,

        /// <summary>
        /// The planned duration field.
        /// </summary>
        [XurrentEnum("plannedDuration")]
        PlannedDuration,

        /// <summary>
        /// The planned effort field.
        /// </summary>
        [XurrentEnum("plannedEffort")]
        PlannedEffort,

        /// <summary>
        /// The planned effort project manager field.
        /// </summary>
        [XurrentEnum("plannedEffortProjectManager")]
        PlannedEffortProjectManager,

        /// <summary>
        /// The planned effort requester field.
        /// </summary>
        [XurrentEnum("plannedEffortRequester")]
        PlannedEffortRequester,

        /// <summary>
        /// The planned effort requester business unit manager field.
        /// </summary>
        [XurrentEnum("plannedEffortRequesterBusinessUnitManager")]
        PlannedEffortRequesterBusinessUnitManager,

        /// <summary>
        /// The planned effort requester manager field.
        /// </summary>
        [XurrentEnum("plannedEffortRequesterManager")]
        PlannedEffortRequesterManager,

        /// <summary>
        /// The planned effort service owner field.
        /// </summary>
        [XurrentEnum("plannedEffortServiceOwner")]
        PlannedEffortServiceOwner,

        /// <summary>
        /// The required approvals field.
        /// </summary>
        [XurrentEnum("requiredApprovals")]
        RequiredApprovals,

        /// <summary>
        /// The skill pool field.
        /// </summary>
        [XurrentEnum("skillPool")]
        SkillPool,

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
        /// The subject field.
        /// </summary>
        [XurrentEnum("subject")]
        Subject,

        /// <summary>
        /// The supplier field.
        /// </summary>
        [XurrentEnum("supplier")]
        Supplier,

        /// <summary>
        /// The team field.
        /// </summary>
        [XurrentEnum("team")]
        Team,

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
        /// The work hours are 24x7 field.
        /// </summary>
        [XurrentEnum("workHoursAre24x7")]
        WorkHoursAre24x7
    }
}
