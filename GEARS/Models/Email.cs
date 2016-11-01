using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GEARS.Models
{
    public class Email
    {
        public Professor Professor { get; set; }
        public List<Course> Courses { get; set; }
    }
}