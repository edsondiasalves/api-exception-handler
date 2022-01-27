using System.Net;
using api_exception_handler.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace api_exception_handler.Filters
{
    public class GlobalExceptionHandlerFilter2 : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var errorCode = 500;

            if (context.Exception is BaseException baseException)
            {
                errorCode = baseException.ErrorCode;
            }

            var customResponse = new InternalErrorResponse{ ErrorCode = errorCode};
            context.Result = new ObjectResult(customResponse){ StatusCode = ((int)HttpStatusCode.InternalServerError) };
        }
    }
}
