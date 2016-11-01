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
            /*test1.Professor = new Professor();
            test1.Professor.Name = "Daniel Stephenson";
            test1.Professor.Fac_id = 8129;
            test1.Professor.Email = "danielstephenson@letu.edu";
            test1.Query = query;
            test1.Title = 
            */
            return new List<Course>();
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