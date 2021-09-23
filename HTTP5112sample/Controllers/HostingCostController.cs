using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112sample.Controllers
{
    public class HostingCostController : ApiController
    {
        //Get api/HostingCost/{id}
        public string[] Get(int id)
        {
            double a = 5.50;  //1 fortnights cost
            double b = 0.13;  //HST
            double c = id / 14;
            double d = c + 1;
            double fortnights = a * d; // multiply the quotient of c with the fortnights to get the cost based on 14 day interval
            double hst = fortnights * b; // multiply the fortnights with hst to get the tax value
            double total = fortnights + hst; // add the tax to the fortnights to get the total
            total = Math.Round(total, 2);    // an inbuild function to round up the decimal point to two digits
            a = Math.Round(a, 2);
            return new string[] { id.ToString() + " fortnights at $5.50/FN = $" + a.ToString() + "CAD" , "HST 13 % = $" + hst.ToString() + "CAD" , "Total = $" + total.ToString() + "CAD"};    // used toString() method to convert data type to string. And changed the values controller values as value1/n,value2/n and value3/n

        }
    }
}
