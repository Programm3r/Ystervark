using System;
using System.Net;
using System.Security.Authentication;

namespace Ystervark.Manager.Exceptions
{
    /// <summary>
    /// Invalid Credentials Exception Class
    /// </summary>
    /// <seealso cref="System.Security.Authentication.AuthenticationException" />
    public class UnauthorisedException : AuthenticationException
    {
        /// <summary>
        /// Gets the status code.
        /// </summary>
        /// <value>
        /// The status code.
        /// </value>
        public HttpStatusCode StatusCode => HttpStatusCode.Unauthorized;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorisedException"/> class.
        /// </summary>
        public UnauthorisedException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorisedException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public UnauthorisedException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorisedException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public UnauthorisedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}