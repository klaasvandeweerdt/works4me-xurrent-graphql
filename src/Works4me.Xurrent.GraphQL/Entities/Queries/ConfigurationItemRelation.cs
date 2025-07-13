using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Works4me.Xurrent.GraphQL.Attributes;
using Works4me.Xurrent.GraphQL.Builders;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/configurationitemrelation/">ConfigurationItemRelation</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    [XurrentEntity("ConfigurationItemRelation")]
    public sealed class ConfigurationItemRelation : IDataItem, INode
    {
        /// <summary>
        /// Related configuration item.
        /// </summary>
        [XurrentField("configurationItem")]
        public ConfigurationItem? ConfigurationItem { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [XurrentField("id", IsDefaultQueryProperty = true)]
        public string Id { get; internal set; } = string.Empty;

        /// <summary>
        /// The type of the relation. Valid values are:<br />
        ///   • <c>parent</c>: Use this relation type to link a software CI to the software suite or software distribution package that it is a module or application of. Also use this relation type to link a virtual machine, software distribution package or software CI to the physical computers on which it has been installed. This relation type is also used to link a hardware CI to the hardware CI that it is a component of, installed in, or directly connected to (not using the network). In case of an address CI, this relation type is used to create a link with the CI to which the address has been assigned.<br />
        ///   • <c>child</c>: Use this relation type to link a software suite or software distribution package to the software modules or applications that it is made up of. Also use this relation type to link a physical computer to the virtual machines, software distribution packages or software CIs that have been installed on it. This relation type is also used to link a hardware CI to its hardware components, CIs that have been installed in it, and CIs that are directly connected to it (not using the network). It is also used to link the addresses that have been assigned to it.<br />
        ///   • <c>network_connection</c>: Use this relation type to link a hardware CI to all other hardware CIs that have a direct network connection with this CI (e.g. a router to a switch).<br />
        ///   • <c>redundancy</c>: Use this relation type to link a hardware CI to all other hardware CIs that provide it redundancy. For example, a server that forms a cluster with another server.<br />
        ///   • <c>continuity</c>: Use this relation type to link a hardware CI to another hardware CI that is located at another site and which is to be used as replacement in case the service instance that the first hardware CI supports needs to be recovered at its continuity site.<br />
        ///   • <c>software_dependency</c>: Use this relation type to link a software CI to all other software CIs, software/interface configurations and databases that depend on this software CI, or which the software CI depends on.<br />
        /// </summary>
        [XurrentField("relationType")]
        public CiRelationRelationType? RelationType { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the relation or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source { get; internal set; }

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
        }

        /// <summary>
        /// <br>Returns an enumerable collection of <see cref="ExecutionPageInfo"/> objects describing the pagination state for this item and its children at the specified depth.</br>
        /// <br>This is used to track paging information when working with nested or related data collections.</br>
        /// </summary>
        /// <param name="depth">The maximum recursion depth for retrieving page information.</param>
        IEnumerable<ExecutionPageInfo> IDataItem.GetPageInfo(int depth)
        {
            return Enumerable.Empty<ExecutionPageInfo>();
        }
    }
}
