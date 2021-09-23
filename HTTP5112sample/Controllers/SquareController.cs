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
        //Get api/Square/{id}
        public int Get(int id)
        {
            int a = id * id;     //storing the square of id in integer variable a.
            return a;
        }
    }
}
