using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GEARS.Models;

namespace GEARS.Helpers
{
    public class DBHelper
    {
        public List<Professor> FindProfessorsByQuery(Query query)
        {
            //STUB
            return new List<Professor>();
        }
        public List<Course> FindCoursesByQuery(Query query)
        {
            //STUB
            Course test1 = new Course();
            test1.Professor = new Professor();
            test1.Professor.Name = "Daniel Stephenson";
            test1.Professor.Fac_id = 8129;
            test1.Professor.Email = "danielstephenson@letu.edu";
            test1.Query = query;
            test1.Title = "History with me";
            test1.Length = "Full";
            test1.Section = "01";
            test1.Number = "HIST3015";
            Course test2 = new Course();
            test2.Professor = new Professor();
            test2.Professor.Name = "Daniel Stephenson";
            test2.Professor.Fac_id = 8129;
            test2.Professor.Email = "danielstephenson@letu.edu";
            test2.Query = query;
            test2.Title = "Math with me";
            test2.Length = "Full";
            test2.Section = "02";
            test2.Number = "MATH2015";
            List<Course> courses = new List<Course>();
            courses.Add(test1);
            courses.Add(test2);
            return courses;
        }
        public DueDates FindDueDatesByQuery(Query query)
        {
            //STUB
            DueDates dueDate = new DueDates();
            dueDate.DueDate = DateTime.Now;
            dueDate.GradDueTime = DateTime.Now;
            return dueDate;
        }
        public String SaveDueDates(Query query, DueDates data)
        {
            //STUB
            return "success";
        }
    }
}