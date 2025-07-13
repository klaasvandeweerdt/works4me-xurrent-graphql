using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// The ci license type values.
    /// </summary>
    public enum CiLicenseType
    {
        /// <summary>
        /// Concurrent user license.
        /// </summary>
        [XurrentEnum("concurrent_user_license")]
        ConcurrentUserLicense,

        /// <summary>
        /// Cpu license.
        /// </summary>
        [XurrentEnum("cpu_license")]
        CpuLicense,

        /// <summary>
        /// Installed user license.
        /// </summary>
        [XurrentEnum("installed_user_license")]
        InstalledUserLicense,

        /// <summary>
        /// Named user license.
        /// </summary>
        [XurrentEnum("named_user_license")]
        NamedUserLicense,

        /// <summary>
        /// Other type of license.
        /// </summary>
        [XurrentEnum("other_type_of_license")]
        OtherTypeOfLicense,

        /// <summary>
        /// Unlimited user license.
        /// </summary>
        [XurrentEnum("unlimited_user_license")]
        UnlimitedUserLicense
    }
}
