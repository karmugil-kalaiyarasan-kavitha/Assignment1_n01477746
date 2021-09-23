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
        //Get api/Greeting/{id}
        public string Get(int id)
        {
            return "Greetings to " + id.ToString() + " people!";         //used toString() to convert the integer value into string.
        }
        //Post api/Greeting
        public string Post()
        {
           return "Hello World";
        }
    }
}
