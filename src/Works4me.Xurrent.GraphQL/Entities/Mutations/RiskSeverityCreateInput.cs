﻿using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/riskseveritycreateinput/">RiskSeverityCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class RiskSeverityCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _description;
        private bool? _disabled;
        private string? _information;
        private Collection<AttachmentInput>? _informationAttachments;
        private long? _position;
        private string _name;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [XurrentField("clientMutationId")]
        public string? ClientMutationId
        {
            get => _clientMutationId;
            set => _clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [XurrentField("source")]
        public string? Source
        {
            get => _source;
            set => _source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [XurrentField("sourceID")]
        public string? SourceID
        {
            get => _sourceID;
            set => _sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// A very short description of the risk severity, for example "Risk is Significant".
        /// </summary>
        [XurrentField("description")]
        public string? Description
        {
            get => _description;
            set => _description = Set("description", value);
        }

        /// <summary>
        /// Whether the risk severity may not be related to any more risks.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// Any additional information about the risk severity that might prove useful, especially for risk managers when they need to decide which severity to select for a risk.
        /// </summary>
        [XurrentField("information")]
        public string? Information
        {
            get => _information;
            set => _information = Set("information", value);
        }

        /// <summary>
        /// The attachments used in the <c>information</c> field.
        /// </summary>
        [XurrentField("informationAttachments")]
        public Collection<AttachmentInput>? InformationAttachments
        {
            get => _informationAttachments;
            set => _informationAttachments = Set("informationAttachments", value);
        }

        /// <summary>
        /// The position that the risk severity takes when it is displayed in a sorted list.
        /// </summary>
        [XurrentField("position")]
        public long? Position
        {
            get => _position;
            set => _position = Set("position", value);
        }

        /// <summary>
        /// The name of the risk severity. Ideally the name of a risk severity consists of a single word, such as "High".
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiskSeverityCreateInput"/> class without providing the required values.
        /// </summary>
        public RiskSeverityCreateInput()
        {
            _name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiskSeverityCreateInput"/> class.
        /// </summary>
        public RiskSeverityCreateInput(string name)
        {
            _name = Set("name", name);
        }
    }
}
