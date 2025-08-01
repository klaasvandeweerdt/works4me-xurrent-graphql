﻿using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent a <see href="https://developer.xurrent.com/graphql/object/pdfdesigncreateinput/">PdfDesignCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class PdfDesignCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private PdfDesignCategory? _category;
        private string? _description;
        private Collection<AttachmentInput>? _descriptionAttachments;
        private bool? _disabled;
        private string? _html;
        private string? _css;
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
        /// Category of the design.
        /// </summary>
        [XurrentField("category")]
        public PdfDesignCategory? Category
        {
            get => _category;
            set => _category = Set("category", value);
        }

        /// <summary>
        /// Description of the design.
        /// </summary>
        [XurrentField("description")]
        public string? Description
        {
            get => _description;
            set => _description = Set("description", value);
        }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        [XurrentField("descriptionAttachments")]
        public Collection<AttachmentInput>? DescriptionAttachments
        {
            get => _descriptionAttachments;
            set => _descriptionAttachments = Set("descriptionAttachments", value);
        }

        /// <summary>
        /// Whether the design is to be used.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// HTML of the design.
        /// </summary>
        [XurrentField("html")]
        public string? Html
        {
            get => _html;
            set => _html = Set("html", value);
        }

        /// <summary>
        /// CSS of the design.
        /// </summary>
        [XurrentField("css")]
        public string? Css
        {
            get => _css;
            set => _css = Set("css", value);
        }

        /// <summary>
        /// Name of the design.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfDesignCreateInput"/> class without providing the required values.
        /// </summary>
        public PdfDesignCreateInput()
        {
            _name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfDesignCreateInput"/> class.
        /// </summary>
        public PdfDesignCreateInput(string name)
        {
            _name = Set("name", name);
        }
    }
}
