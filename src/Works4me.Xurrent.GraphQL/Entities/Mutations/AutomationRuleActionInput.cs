using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/automationruleactioninput/">AutomationRuleActionInput</see> in Xurrent.
    /// </summary>
    public sealed class AutomationRuleActionInput : PropertyChangeSet
    {
        private string _name;
        private string _value;

        /// <summary>
        /// Name of the action.
        /// </summary>
        [XurrentField("name")]
        public string Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// The action that should be executed when the condition of the automation rule is met. Takes one of the following forms:<br />
        /// • <c>update &lt;record&gt; set &lt;field&gt; = &lt;value&gt;</c>.<br />
        /// • <c>update &lt;record&gt; add &lt;value&gt; to &lt;collection&gt;</c>.<br />
        /// • <c>update &lt;record&gt; remove &lt;value&gt; from &lt;collection&gt;</c>.<br />
        /// • <c>update &lt;record&gt; clear &lt;collection&gt;</c>.<br />
        /// • <c>update &lt;record&gt; add note '&lt;value&gt;'</c>.<br />
        /// • <c>after &lt;delay&gt; trigger '&lt;rule&gt;'</c>.<br />
        /// • <c>call webhook '&lt;webhook&gt;' with payload '&lt;payload&gt;'</c>.<br />
        /// When the action operates on the current record, leave out <c>update &lt;record&gt;</c>.<br />
        /// Examples:<br />
        /// • <c>update workflow set manager = my_person</c>.<br />
        /// • <c>add my_ci to cis</c>.<br />
        /// • <c>add note 'Hello {{@my_person}}'</c>.<br />
        /// • <c>after 30.minutes trigger 'My Delay Rule'</c>.<br />
        /// • <c>call webhook 'My Webhook' with payload 'my_payload'</c>.<br />
        /// </summary>
        [XurrentField("value")]
        public string Value
        {
            get => _value;
            set => _value = Set("value", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleActionInput"/> class without providing the required values.
        /// </summary>
        public AutomationRuleActionInput()
        {
            _name = string.Empty;
            _value = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationRuleActionInput"/> class.
        /// </summary>
        public AutomationRuleActionInput(string name, string value)
        {
            _name = Set("name", name);
            _value = Set("value", value);
        }
    }
}
