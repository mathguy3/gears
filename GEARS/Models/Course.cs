using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GEARS.Models
{
    public class Course
    {
        public Query Query { get; set; }

        public DueDates DueDates { get; set; }

        public Professor Professor { get; set; }

        public String Number { get; set; }
        public String Section { get; set; }
        public String Title { get; set; }
        public String Length { get; set; }
    }
}