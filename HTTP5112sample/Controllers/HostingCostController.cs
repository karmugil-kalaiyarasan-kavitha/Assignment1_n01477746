﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112sample.Controllers
{
    public class HostingCostController : ApiController
    {
        
        public string Get(int id)
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
            return id.ToString()+" fortnights at $5.50/FN = $"+a.ToString() +"CAD\n" + "HST 13 % = $" + hst.ToString() +"CAD\n" + "Total = $"+total.ToString()+"CAD";

        }
    }
}
