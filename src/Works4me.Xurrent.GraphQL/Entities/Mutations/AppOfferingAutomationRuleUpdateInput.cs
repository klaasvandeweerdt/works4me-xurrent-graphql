using System.Collections.ObjectModel;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/appofferingautomationruleupdateinput/">AppOfferingAutomationRuleUpdateInput</see> in Xurrent.
    /// </summary>
    public sealed class AppOfferingAutomationRuleUpdateInput : PropertyChangeSet
    {
        private string? _clientMutationId;
        private Collection<AutomationRuleActionInput>? _actions;
        private string? _condition;
        private string? _description;
        private Collection<AutomationRuleExpressionInput>? _expressions;
        private string? _generic;
        private string? _name;
        private long? _position;
        private string? _trigger;
        private string _id;

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
        /// The Actions field is used to define actions that should be executed when the condition of the automation rule is met.
        /// </summary>
        [XurrentField("actions")]
        public Collection<AutomationRuleActionInput>? Actions
        {
            get => _actions;
            set => _actions = Set("actions", value);
        }

        /// <summary>
        /// The Condition field is used to define the condition that needs to be met in order for the update action(s) of the rule to be performed. For example: <c>is_assigned and !badge</c>.
        /// </summary>
        [XurrentField("condition")]
        public string? Condition
        {
            get => _condition;
            set => _condition = Set("condition", value);
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
        /// The Expressions field is used to define expressions that can subsequently be used to define the rule's conditions and the update action(s) that the rule is to perform.
        /// </summary>
        [XurrentField("expressions")]
        public Collection<AutomationRuleExpressionInput>? Expressions
        {
            get => _expressions;
            set => _expressions = Set("expressions", value);
        }

        /// <summary>
        /// The record type this rule is linked to.<br />
        /// Valid values are:<br />
        ///   • <c>request</c>.<br />
        ///   • <c>task</c>.<br />
        ///   • <c>ci</c>.<br />
        /// </summary>
        [XurrentField("generic")]
        public string? Generic
        {
            get => _generic;
            set => _generic = Set("generic", value);
        }

        /// <summary>
        /// The name of the automation rule.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
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
        /// The Trigger field is used to specify when the automation rule is to be triggered, for example <c>on status update</c> or <c>on note added</c>.
        /// </summary>
        [XurrentField("trigger")]
        public string? Trigger
        {
            get => _trigger;
            set => _trigger = Set("trigger", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [XurrentField("id")]
        public string Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingAutomationRuleUpdateInput"/> class without providing the required values.
        /// </summary>
        public AppOfferingAutomationRuleUpdateInput()
        {
            _id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppOfferingAutomationRuleUpdateInput"/> class.
        /// </summary>
        public AppOfferingAutomationRuleUpdateInput(string id)
        {
            _id = Set("id", id);
        }
    }
}
