using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/automationrulecreateinput/">AutomationRuleCreateInput</see> in Xurrent.
    /// </summary>
    public sealed class AutomationRuleCreateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private string? _source;
        private string? _sourceID;
        private string? _description;
        private bool? _disabled;
        private string? _generic;
        private string? _ownerId;
        private long? _position;
        private string _name;
        private string _trigger;
        private Collection<AutomationRuleExpressionInput>? _expressions;
        private string _condition;
        private Collection<AutomationRuleActionInput>? _actions;

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
        /// A high-level description of the automation rule's function.
        /// </summary>
        [XurrentField("description")]
        public string? Description
        {
            get => _description;
            set => _description = Set("description", value);
        }

        /// <summary>
        /// Whether the automation rule should not be triggered.
        /// </summary>
        [XurrentField("disabled")]
        public bool? Disabled
        {
            get => _disabled;
            set => _disabled = Set("disabled", value);
        }

        /// <summary>
        /// When the automation rule is not linked to one specific record but to all records of a type, the Generic field contains the record type. Valid values are:<br />
        /// • <c>request</c>.<br />
        /// • <c>problem</c>.<br />
        /// • <c>workflow</c>.<br />
        /// • <c>task</c>.<br />
        /// • <c>project_task</c>.<br />
        /// • <c>ci</c>.<br />
        /// • <c>risk</c>.<br />
        /// • <c>scim_user</c>.<br />
        /// • <c>scim_group</c>.<br />
        /// </summary>
        [XurrentField("generic")]
        public string? Generic
        {
            get => _generic;
            set => _generic = Set("generic", value);
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// </summary>
        [XurrentField("ownerId")]
        public string? OwnerId
        {
            get => _ownerId;
            set => _ownerId = Set("ownerId", value);
        }

        /// <summary>
        /// The Position field dictates the order in which the automation rule is executed.
        /// </summary>
        [XurrentField("position")]
        public long? Position
        {
            get => _position;
            set => _position = Set("position", value);
        }

        /// <summary>
        /// The name of the automation rule.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The Trigger field is used to specify when the automation rule is to be triggered, for example <c>on status update</c> or <c>on note added</c>.
        /// </summary>
        [XurrentField("trigger")]
        public string Trigger
        {
            get => _trigger;
            set => _trigger = Set("trigger", value);
        }

        /// <summary>
        /// The Expressions field is used to define expressions that can subsequently be used to define the rule's conditions and the update action(s) that the rule is to perform.
        /// </summary>
        [XurrentField("expressions")]
        public Collection<AutomationRuleExpressionInput>? Expressions
        {
            get => _expressions;
            set => _expressions = Set("expressions", value);
        }

        /// <summary>
        /// The Condition field is used to define the condition that needs to be met in order for the update action(s) of the rule to be performed. For example: <c>is_assigned and !badge</c>.
        /// </summary>
        [XurrentField("condition")]
        public string Condition
        {
            get => _condition;
            set => _condition = Set("condition", value);
        }

        /// <summary>
        /// The Actions field is used to define actions that should be executed when the condition of the automation rule is met.
        /// </summary>
        [XurrentField("actions")]
        public Collection<AutomationRuleActionInput>? Actions
        {
            get => _actions;
            set => _actions = Set("actions", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleCreateInput"/> class without providing the required values.
        /// </summary>
        public AutomationRuleCreateInput()
        {
            _name = string.Empty;
            _trigger = string.Empty;
            _condition = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleCreateInput"/> class.
        /// </summary>
        public AutomationRuleCreateInput(string name, string trigger, string condition)
        {
            _name = Set("name", name);
            _trigger = Set("trigger", trigger);
            _condition = Set("condition", condition);
        }
    }
}
