using System.Collections.Generic;

namespace GEARS.Models
{
    public class Email
    {
        public Professor Professor { get; set; }
        public List<Course> Courses { get; set; }
    }
}