using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GEARS.Models
{
    public class Query
    {
        public string Session { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string DegreeGroup { get; set; }
        public string TuitCode { get; set; }
    }
}