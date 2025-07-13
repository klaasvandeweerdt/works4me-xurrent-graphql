using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represents errors returned by the GraphQL execution engine, including the execution path.
    /// </summary>
    [Serializable]
    public class XurrentExecutionException : XurrentException
    {
        private readonly List<string> _path = new();

        /// <summary>
        /// Gets the GraphQL execution path where the error occurred.
        /// </summary>
        public IReadOnlyList<string> Path 
        {
            get => _path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentExecutionException"/> class.
        /// </summary>
        public XurrentExecutionException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentExecutionException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public XurrentExecutionException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentExecutionException"/> class with a specified error message and execution path.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="path">The GraphQL execution path as a sequence of field names.</param>
        public XurrentExecutionException(string message, IReadOnlyList<string> path)
            : base(message)
        {
            _path.AddRange(path);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentExecutionException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public XurrentExecutionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentExecutionException"/> class with a specified error message, inner exception, and execution path.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        /// <param name="path">The GraphQL execution path as a sequence of field names.</param>
        public XurrentExecutionException(string message, Exception innerException, IReadOnlyList<string> path)
            : base(message, innerException)
        {
            _path.AddRange(path);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentExecutionException"/> class with serialized data. Only included on .NET Framework.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected XurrentExecutionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            string[]? arr = (string[]?)info.GetValue(nameof(Path), typeof(string[]));
            _path = arr is not null
                ? new List<string>(arr)
                : new List<string>();
        }

        /// <summary>
        /// Populates a <see cref="SerializationInfo"/> with the data needed to serialize the <see cref="XurrentExecutionException"/> object. Only included on .NET Framework.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> to populate with serialized data.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that describes the source and destination.</param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info is null)
                throw new ArgumentNullException(nameof(info));

            base.GetObjectData(info, context);
            info.AddValue(nameof(Path), _path.ToArray(), typeof(string[]));
        }
#endif

        /// <summary>
        /// Returns a string representation of this exception, including the GraphQL execution path if available.
        /// </summary>
        /// <returns>A string that represents the current exception.</returns>
        public override string ToString()
        {
            string message = Message ?? string.Empty;

            if (_path.Count > 0)
            {
                string pathString = string.Join(".", _path);
                return message.Length > 0 ? $"{message}{Environment.NewLine}GraphQL Path: {pathString}" : $"GraphQL Path: {pathString}";
            }

            return message;
        }
    }
}
