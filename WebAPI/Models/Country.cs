using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Country
    {
        public string name { get; set; }
        public string alpha3code { get; set; }
        public string capital { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public int population { get; set; }
    }
}