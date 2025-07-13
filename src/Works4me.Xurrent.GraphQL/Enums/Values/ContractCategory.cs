using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The contract category values.
    /// </summary>
    public enum ContractCategory
    {
        /// <summary>
        /// Lease contract.
        /// </summary>
        [XurrentEnum("lease_contract")]
        LeaseContract,

        /// <summary>
        /// Maintenance contract.
        /// </summary>
        [XurrentEnum("maintenance_contract")]
        MaintenanceContract,

        /// <summary>
        /// Other type of contract.
        /// </summary>
        [XurrentEnum("other_type_of_contract")]
        OtherTypeOfContract,

        /// <summary>
        /// Support maintenance contract.
        /// </summary>
        [XurrentEnum("support_and_maintenance_contract")]
        SupportAndMaintenanceContract,

        /// <summary>
        /// Support contract.
        /// </summary>
        [XurrentEnum("support_contract")]
        SupportContract
    }
}
