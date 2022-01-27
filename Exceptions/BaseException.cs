
using System;

namespace api_exception_handler.Exceptions
{
    public class BaseException : Exception
    {
        private Exception _innerException;
        public BaseException(Exception innerException) 
        {
            _innerException = innerException;
        }

        public virtual int ErrorCode { get; }
    }
}
