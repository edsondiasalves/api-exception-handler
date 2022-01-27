
using System;

namespace api_exception_handler.Exceptions
{
    public class GeneralException : Exception
    {
        public GeneralException(String message, int errorCode) : base (message)
        {
            this.ErrorCode = errorCode;
        }

        public int ErrorCode { get; set; }
    }
}
