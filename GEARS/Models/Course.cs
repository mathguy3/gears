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