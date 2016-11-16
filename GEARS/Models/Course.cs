using System;

namespace GEARS.Models
{
    public class Course
    {
        public Query Query { get; set; }

        public DueDates DueDates { get; set; }

        public Professor Professor { get; set; }

        public string Number { get; set; }
        public string Section { get; set; }
        public string Title { get; set; }
        public string Length { get; set; }

        public Course(){}

        public Course(Query query, DueDates dueDates, Professor professor,
            string number, string section, string title, string length)
        {
            Query = query;
            DueDates = dueDates;
            Professor = professor;
            Number = number;
            Section = section;
            Title = title;
            Length = length;
        }
    }
}