using System;

namespace Works4me.Xurrent.GraphQL
{
    /// <summary>
    /// Represents errors thrown by the Xurrent SDK.
    /// </summary>
    [Serializable]
    public class XurrentException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentException"/> class.
        /// </summary>
        public XurrentException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public XurrentException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XurrentException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public XurrentException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

#if NETFRAMEWORK
        /// <summary>
        /// Serialization constructor only included on .NET Framework.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected XurrentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}
