﻿using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Filter to determine which Team records are returned.
    /// </summary>
    public enum TeamFilterField
    {
        /// <summary>
        /// Filter on Coordinator.
        /// </summary>
        [XurrentEnum("coordinator")]
        Coordinator,

        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [XurrentEnum("createdAt")]
        CreatedAt,

        /// <summary>
        /// Include only if Disabled matches supplied value.
        /// </summary>
        [XurrentEnum("disabled")]
        Disabled,

        /// <summary>
        /// Filter on node ID.
        /// </summary>
        [XurrentEnum("id")]
        Id,

        /// <summary>
        /// Filter on Manager.
        /// </summary>
        [XurrentEnum("manager")]
        Manager,

        /// <summary>
        /// Filter on Name.
        /// </summary>
        [XurrentEnum("name")]
        Name,

        /// <summary>
        /// Filter on Source.
        /// </summary>
        [XurrentEnum("source")]
        Source,

        /// <summary>
        /// Filter on Source ID.
        /// </summary>
        [XurrentEnum("sourceID")]
        SourceID,

        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [XurrentEnum("updatedAt")]
        UpdatedAt
    }
}
