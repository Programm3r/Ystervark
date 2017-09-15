using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Ystervark.Manager.Exceptions;
using Ystervark.Models.Helper;

namespace Ystervark.API.Middleware
{
    /// <summary>
    /// Error Handling Middle-ware Class
    /// </summary>
    public class ErrorHandlingMiddleware
    {
        /// <summary>
        /// The next request
        /// </summary>
        private readonly RequestDelegate _next;

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorHandlingMiddleware"/> class.
        /// </summary>
        /// <param name="next">The next.</param>
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        /// <summary>
        /// Invokes the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context /* other scoped dependencies */)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        /// <summary>
        /// Handles the exception asynchronous.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="exception">The exception.</param>
        /// <returns></returns>
        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = HttpStatusCode.InternalServerError; // 500 if unexpected

            switch (exception)
            {
                case NoDataFoundException _:
                    code = HttpStatusCode.NotFound;
                    break;
                case UnauthorisedException _:
                    code = HttpStatusCode.Unauthorized;
                    break;
                case ValidationException _:
                    code = HttpStatusCode.BadRequest;
                    break;
            }

            var result = JsonConvert.SerializeObject(new Response<object>
            {
                IsSuccess = false,
                Message = string.Empty,
                Data = default(object),
                Error = exception.ToString()
            });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int) code;
            return context.Response.WriteAsync(result);
        }
    }
}