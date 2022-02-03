using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        private readonly ILogger _logger;

        public ExamplesController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("LogInformation")]
        public string LogInformation()
        {
            string response = "Hello, Serilog! (Information)";
            _logger.Information($"Returned {response} text.");
            return response;
        }

        [HttpGet]
        [Route("LogDebug")]
        public string LogDebug()
        {
            string response = "Hello, Serilog! (Debug)";
            _logger.Information($"Returned {response} text.");
            return response;
        }

        [HttpGet]
        [Route("LogException")]
        public string LogException()
        {
            throw new Exception("Exception example 1");
        }

        [HttpGet]
        [Route("DivideByZero")]
        public string DivideByZero()
        {
            int a = 1;
            int b = 1;
            return $"{0/(b-a)}";
        }
    }
}
