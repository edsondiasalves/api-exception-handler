
using System;

namespace api_exception_handler.Exceptions
{
    public class FirstServiceException : BaseException
    {
        public FirstServiceException(Exception innerException) : base(innerException) {}

        public override int ErrorCode { get => 789; }
    }
}
