using System.Diagnostics;
using Works4me.Xurrent.GraphQL.Attributes;

namespace Works4me.Xurrent.GraphQL.Mutations
{
    /// <summary>
    /// Represent an <see href="https://developer.xurrent.com/graphql/object/agileboardcolumninput/">AgileBoardColumnInput</see> in Xurrent.
    /// </summary>
    [DebuggerDisplay("{Id}")]
    public sealed class AgileBoardColumnInput : PropertyChangeSet
    {
        private string? _id;
        private AgileBoardColumnActionType? _actionType;
        private bool? _clearMember;
        private AgileBoardColumnDialogType? _dialogType;
        private string? _name;
        private string? _memberId;
        private long? _position;
        private long? _removeAfter;
        private string? _teamId;
        private long? _wipLimit;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [XurrentField("id")]
        public string? Id
        {
            get => _id;
            set => _id = Set("id", value);
        }

        /// <summary>
        /// Type of action to perform when an item is added to this column.
        /// </summary>
        [XurrentField("actionType")]
        public AgileBoardColumnActionType? ActionType
        {
            get => _actionType;
            set => _actionType = Set("actionType", value);
        }

        /// <summary>
        /// Should the assigned person field of an item be cleared when the action type is <c>assign</c> and the item is added to this column?.
        /// </summary>
        [XurrentField("clearMember")]
        public bool? ClearMember
        {
            get => _clearMember;
            set => _clearMember = Set("clearMember", value);
        }

        /// <summary>
        /// Type of dialog to open when an item is added to this column.
        /// </summary>
        [XurrentField("dialogType")]
        public AgileBoardColumnDialogType? DialogType
        {
            get => _dialogType;
            set => _dialogType = Set("dialogType", value);
        }

        /// <summary>
        /// Name of the column.
        /// </summary>
        [XurrentField("name")]
        public string? Name
        {
            get => _name;
            set => _name = Set("name", value);
        }

        /// <summary>
        /// Identifier of the person to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        [XurrentField("memberId")]
        public string? MemberId
        {
            get => _memberId;
            set => _memberId = Set("memberId", value);
        }

        /// <summary>
        /// Relative position of the column.
        /// </summary>
        [XurrentField("position")]
        public long? Position
        {
            get => _position;
            set => _position = Set("position", value);
        }

        /// <summary>
        /// Items in this column will be removed from the board if they are not explicitly moved in this many days.
        /// </summary>
        [XurrentField("removeAfter")]
        public long? RemoveAfter
        {
            get => _removeAfter;
            set => _removeAfter = Set("removeAfter", value);
        }

        /// <summary>
        /// Identifier of the team to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        [XurrentField("teamId")]
        public string? TeamId
        {
            get => _teamId;
            set => _teamId = Set("teamId", value);
        }

        /// <summary>
        /// Work-in-progress limit for the column.
        /// </summary>
        [XurrentField("wipLimit")]
        public long? WipLimit
        {
            get => _wipLimit;
            set => _wipLimit = Set("wipLimit", value);
        }
    }
}
