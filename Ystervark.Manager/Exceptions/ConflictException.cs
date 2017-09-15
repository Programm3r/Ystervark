using System;
using System.Net;

namespace Ystervark.Manager.Exceptions
{
    /// <summary>
    /// Conflict Exception Class
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ConflictException : Exception
    {
        /// <summary>
        /// Gets the status code.
        /// </summary>
        /// <value>
        /// The status code.
        /// </value>
        public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictException"/> class.
        /// </summary>
        public ConflictException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ConflictException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public ConflictException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}