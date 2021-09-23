using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112sample.Controllers
{

    public class AddTenController : ApiController
    {
        //Get api/AddTen/{id}
        public int Get(int id)
        {
            int a = id + 10;       //added 10 to the id and stored in a integer variable a.
            return a;
        }
    }
}
