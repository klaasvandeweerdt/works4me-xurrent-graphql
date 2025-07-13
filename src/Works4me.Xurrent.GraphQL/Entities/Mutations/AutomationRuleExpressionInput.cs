using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/automationruleexpressioninput/">AutomationRuleExpressionInput</see> in Xurrent.
    /// </summary>
    public sealed class AutomationRuleExpressionInput : PropertyChangeSet
    {
        private string _name;
        private string _value;

        /// <summary>
        /// Name of the expression, which can be used to refer to the expression from the rule's conditions, actions, or from other expressions.'.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The value of the expression. Refer to the Xurrent Help for guidance on how to form valid expressions.
        /// </summary>
        [XurrentField("value")]
        public string Value
        {
            get => _value;
            set => _value = Set("value", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleExpressionInput"/> class without providing the required values.
        /// </summary>
        public AutomationRuleExpressionInput()
        {
            _name = string.Empty;
            _value = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleExpressionInput"/> class.
        /// </summary>
        public AutomationRuleExpressionInput(string name, string value)
        {
            _name = Set("name", name);
            _value = Set("value", value);
        }
    }
}
