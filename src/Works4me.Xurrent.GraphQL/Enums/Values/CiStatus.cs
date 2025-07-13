using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The ci status values.
    /// </summary>
    public enum CiStatus
    {
        /// <summary>
        /// Archived.
        /// </summary>
        [XurrentEnum("archived")]
        Archived,

        /// <summary>
        /// Being built.
        /// </summary>
        [XurrentEnum("being_built")]
        BeingBuilt,

        /// <summary>
        /// Being repaired.
        /// </summary>
        [XurrentEnum("being_repaired")]
        BeingRepaired,

        /// <summary>
        /// Being tested.
        /// </summary>
        [XurrentEnum("being_tested")]
        BeingTested,

        /// <summary>
        /// Broken down.
        /// </summary>
        [XurrentEnum("broken_down")]
        BrokenDown,

        /// <summary>
        /// In production.
        /// </summary>
        [XurrentEnum("in_production")]
        InProduction,

        /// <summary>
        /// In stock.
        /// </summary>
        [XurrentEnum("in_stock")]
        InStock,

        /// <summary>
        /// In transit.
        /// </summary>
        [XurrentEnum("in_transit")]
        InTransit,

        /// <summary>
        /// Installed.
        /// </summary>
        [XurrentEnum("installed")]
        Installed,

        /// <summary>
        /// Lent out.
        /// </summary>
        [XurrentEnum("lent_out")]
        LentOut,

        /// <summary>
        /// Lost or stolen.
        /// </summary>
        [XurrentEnum("lost_or_stolen")]
        LostOrStolen,

        /// <summary>
        /// Ordered.
        /// </summary>
        [XurrentEnum("ordered")]
        Ordered,

        /// <summary>
        /// Removed.
        /// </summary>
        [XurrentEnum("removed")]
        Removed,

        /// <summary>
        /// Reserved.
        /// </summary>
        [XurrentEnum("reserved")]
        Reserved,

        /// <summary>
        /// Standby for continuity.
        /// </summary>
        [XurrentEnum("standby_for_continuity")]
        StandbyForContinuity,

        /// <summary>
        /// To be removed.
        /// </summary>
        [XurrentEnum("to_be_removed")]
        ToBeRemoved,

        /// <summary>
        /// Undergoing maintenance.
        /// </summary>
        [XurrentEnum("undergoing_maintenance")]
        UndergoingMaintenance
    }
}
