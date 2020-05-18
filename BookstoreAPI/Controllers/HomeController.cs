using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreAPI.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreAPI.Controllers
{
    /// <summary>
    /// Test API Controller . . .
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILoggerService _logger;
        public HomeController(ILoggerService logger)
        {
            _logger = logger;
        }
        // GET: api/Home1
        /// <summary>
        /// Get Valuess
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Accessed Home Controller");
            return new string[] { "value1", "value2" };
        }

        // GET: api/Home1/5
        /// <summary>
        /// Get a value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            _logger.LogDebug("Got A Value");
            return "value";
        }

        // POST: api/Home1
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogInfo("This is an Error");
        }

        // PUT: api/Home1/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        ///
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogWarn("this is a warning");
        }
    }
}
