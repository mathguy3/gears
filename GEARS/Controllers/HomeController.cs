using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Net.Mail;
using GEARS.Helpers;
using System.Data.Odbc;
using GEARS.Models;

namespace GEARS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        const string EMAILSENDER = "";
        const string EMAILHOSTSERVER = "";

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(String username, String password)
        {
            LoginInfo newLoginInfo = new LoginInfo(username, password);

            return View(newLoginInfo);
        }

        [HttpGet]
        public ActionResult Index()
        {
            //TEST DATA
            FullModel fm = new FullModel();
            QueryPageModel qm = new QueryPageModel();
            qm.Course = new Course();
            qm.Course.Query = new Query();
            qm.Course.Query.Session = "Hai";
            qm.Course.Query.Year = "Whatever";
            qm.Course.Query.Type = "sup";
            EmailsPageModel em = new EmailsPageModel();
            fm.EmailsPageModel = em;
            fm.QueryPageModel = qm;
            //TestConnection();
            return View(fm);
        }

        [HttpGet]
        public ActionResult EditData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditData(Query query, DueDates dueDates)
        {
            Professor prof = new Professor();
            Course course = new Course(query, dueDates, prof, "","","","");
            return View(course);
        }

        [HttpPost]
        public String Query(QueryPageModel search)
        {
            //STUB
            DBHelper db = new DBHelper();
            DueDates result = db.FindDueDatesByQuery(search.Course.Query);
            String editDueDatesPartial = PartialView("_DueDatesPartial", result).RenderToString();
            return editDueDatesPartial;
        }

        [HttpPost]
        public String Emails(QueryPageModel search)
        {
            //STUB
            DBHelper db = new DBHelper();
            List<Course> result = db.FindCoursesByQuery(search.Course.Query);
            Email em = new Email();
            EmailsPageModel emailPageModel = new EmailsPageModel();
            foreach (Course course in result)
            {
	            em.Professor = course.Professor;
	            em.Courses = result;
	            em.DueDates = new DueDates();
	            em.DueDates.DueDate = DateTime.Now;
	            em.DueDates.DueTime = DateTime.Now.Date;
	            em.DueDates.DueTime.AddHours(12);
	            emailPageModel.Emails = new List<Email>();
            	emailPageModel.Emails.Add(em);
            }
            String emailsPartial = PartialView("_EmailsPartial", emailPageModel).RenderToString();
            return emailsPartial;
        }

        [HttpGet]
        public ActionResult Preview()
        {
            return View();
        }

        public String SaveDates(Course course)
        {
            //STUB
            DBHelper db = new DBHelper();
            String result = db.SaveDueDates(course.Query, course.DueDates);
            return result;
        }

        [HttpPost]
        public String SendSelected()
        {
            //STUB
            DBHelper db = new DBHelper();
            String result = "";//db.SaveDueDates(course.Query, course.DueDates);
            return result;
        }

        [HttpPost]
        public String Preview(Email email)
        {
            //STUB
            DBHelper db = new DBHelper();
            String emailsPartial = PartialView("_EmailTemplate", email).RenderToString();
            return emailsPartial;
        }

        public bool SendEmail(Email email)
        {
            MailMessage message = new MailMessage(EMAILSENDER, email.Professor.Email);
            Attachment attachment = new Attachment("pdfdocument");  //Still needs actual document!!!
            message.Attachments.Add(attachment);
            message.Body = "PictureDocument";  //Still needs actual document!!!
            SmtpClient smtp = new SmtpClient(EMAILHOSTSERVER); //Still needs actual HostServerName!!!
            //smtp.Credentials = new NetworkCredential("login", "password");

            smtp.SendCompleted += delegate (object sender, System.ComponentModel.AsyncCompletedEventArgs e)
            {
                if (e.Error != null)
                {
                    System.Diagnostics.Trace.TraceError(e.Error.ToString());
                }
                MailMessage userMessage = e.UserState as MailMessage;
                if (userMessage != null)
                {
                    userMessage.Dispose();
                }
            };

            smtp.SendAsync(message, message);

            return true;
        }
    }
}