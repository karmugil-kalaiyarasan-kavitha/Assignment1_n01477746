using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112sample.Controllers
{
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            int a = id * id;
            return a;
        }
    }
}
