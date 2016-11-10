using System;
using System.Collections.Generic;
using GEARS.Models;
using System.Data.Odbc;

namespace GEARS.Helpers
{
    public class DBHelper
    {
        OdbcConnection db;
        public DBHelper()
        {
            string DSN = "CARSTRAIN";
            var user = "stephend";
            var password = "Chickens";
            string connectionString = String.Format("Dsn={0};Uid={1};Pwd={2}", new Object[] { DSN, user, password });
            db = new OdbcConnection(connectionString);
            
        }
        public List<Professor> FindProfessorsByQuery(Query query)
        {
            // Gets data for the preview page and for an individual email. Should get a list of professors that have classes that match the query, along with the course information
            db.Open();
            OdbcCommand command = new OdbcCommand();
            command.CommandText = "execute procedure lu_nearest_acadcal('UNDG', today)";
            command.Connection = db;

            OdbcDataReader results = command.ExecuteReader();

            while (results.Read())
            {
                var year = results.GetFieldValue<int>(0);
                var session = results.GetFieldValue<string>(1);
            }
            db.Close();
            return new List<Professor>();
        }
        public List<Course> FindCoursesByQuery(Query query)
        {
            // Gets data for the emails page, it should find all the courses that match the given query, along with the professor's information
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
            // Gets data for the edit due dates page, should retrieve the specific set of due dates for the query 
            //STUB
            DueDates dueDate = new DueDates();
            dueDate.DueDate = DateTime.Now;
            dueDate.GradDueTime = DateTime.Now;
            return dueDate;
        }
        public String SaveDueDates(Query query, DueDates data)
        {
            // Sends data to be saved to the database, for the specific query
            //STUB
            return "success";
        }
    }
}