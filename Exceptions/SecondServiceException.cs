
using System;

namespace api_exception_handler.Exceptions
{
    public class SecondServiceException : BaseException
    {
        public SecondServiceException(Exception innerException) : base(innerException) {}

        public override int ErrorCode { get => 854; }
    }
}
