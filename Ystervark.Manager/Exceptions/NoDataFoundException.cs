using System;
using System.Net;

namespace Ystervark.Manager.Exceptions
{
    /// <summary>
    /// No Data Found Exception Class
    /// </summary>
    /// <seealso cref="System.SystemException" />
    public class NoDataFoundException : SystemException
    {
        /// <summary>
        /// Gets the status code.
        /// </summary>
        /// <value>
        /// The status code.
        /// </value>
        public HttpStatusCode StatusCode => HttpStatusCode.NoContent;

        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        public override string Message { get; } = "No content associated with the request - unable to perform action";

        /// <summary>
        /// Initializes a new instance of the <see cref="NoDataFoundException"/> class.
        /// </summary>
        public NoDataFoundException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoDataFoundException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public NoDataFoundException(string message) : base(message)
        {
            this.Message = message;
        }
    }
}