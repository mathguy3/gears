using GEARS.Models;
using System;
using System.Web.Mvc;
using GEARS.Models;
using GEARS.Helpers;

namespace GEARS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
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
            return View(fm);
        }
        [HttpPost]
        public ActionResult Index(String session, String type, String degreeGroup, 
            String tuitCode, int year)
        {
            Course newCourse = new Course(session, type, degreeGroup, tuitCode, year);
            return View(newCourse);
        }

        [HttpGet]
        public ActionResult EditData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditData(String session, String type, String degreeGroup,
            String tuitCode, int year, int dueDate, int dueTime, int gradDueDate, int gradDueTime)
        [HttpPost]
        public String Query(QueryPageModel search)
        {
            Course newCourse = new Course(session, type, degreeGroup, tuitCode, year);
            DueDateTime newDueDateTime = new DueDateTime(dueDate, dueTime, gradDueDate, gradDueTime);

            return View(newDueDateTime);
        }
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
            em.Professor = result.First().Professor;
            em.Courses = result;
            EmailsPageModel emailPageModel = new EmailsPageModel();
            emailPageModel.Emails = new List<Email>();
            emailPageModel.Emails.Add(em);
            String emailsPartial = PartialView("_EmailsPartial", emailPageModel).RenderToString();
            return emailsPartial;
        }
        [HttpPost]
        public ActionResult Emails(int i)
        {
            EmailInfo newEmailInfo = new EmailInfo();

            return View(newEmailInfo);
        }

        [HttpGet]
        public ActionResult Preview()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Preview(int i)
        [HttpPost]
        public String SaveDates(Course course)
        {
            //STUB
            DBHelper db = new DBHelper();
            String result = db.SaveDueDates(course.Query, course.DueDates);
            return result;
            PreviewInfo newPreviewInfo = new PreviewInfo();

            return View(newPreviewInfo);
        }
    }
}