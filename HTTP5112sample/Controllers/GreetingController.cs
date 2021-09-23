using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112sample.Controllers
{
    public class GreetingController : ApiController
    {
        public string Get(string id)
        {
            return "Greetings to " + id + " people!";
        }

        //public string Post()
        //{
         //   return "Hello World";
        //}
    }
}
