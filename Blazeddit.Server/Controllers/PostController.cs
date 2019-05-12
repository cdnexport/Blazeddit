using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Blazeddit.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blazeddit.Server.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/permalink
        [HttpGet("{permalink}")]
        public Comment[] Get(string permalink)
        {
            var request = (HttpWebRequest)WebRequest.Create($"https://reddit.com{permalink}.json");
            request.ContentType = "text/json";
            request.Method = "GET";

            var response = (HttpWebResponse)request.GetResponse();
            Comment[] comments;
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var postResponse = Json(streamReader.ReadToEnd());
                comments = new Comment[0];
            }

            return new Comment[0];
        }
    }
}
