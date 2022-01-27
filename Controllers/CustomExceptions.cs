
using System;
using api_exception_handler.Exceptions;
using api_exception_handler.Services;
using api_exception_handler.Utils;
using Microsoft.AspNetCore.Mvc;

namespace api_exception_handler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomExceptionsController : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            var service = new MultiServices();

            try 
            {
                service.GetFirstInfo();
            } 
            catch (Exception ex) 
            {
                throw new FirstServiceException(ex);
            }

            try 
            {
                service.GetSecondInfo();
            } 
            catch (Exception ex) 
            {
                throw new SecondServiceException(ex);
            }

            return 1;
        }
    }
}
