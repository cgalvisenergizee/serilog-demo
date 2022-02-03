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
            string response = "Hello, Serilog!";
            _logger.Information($"Returned {response} text.");
            return response;
        }

        [HttpGet]
        [Route("LogException")]
        public string LogException()
        {
            throw new Exception("Exception example 1");
        }
    }
}
