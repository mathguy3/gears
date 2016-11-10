using System;

namespace GEARS.Models
{
    public class Course
    {
        public String Session, Type, DegreeGroup, TuitCode;
        public int Year;
       
        public Course()
        {
        }

        public Course(String session, String type, String degreeGroup, String tuitCode, int year)
        {
            Session = session;
            Type = type;
            DegreeGroup = degreeGroup;
            TuitCode = tuitCode;
            Year = year;
        }
    }
}
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