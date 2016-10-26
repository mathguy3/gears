using GEARS.Models;
using System;
using System.Web.Mvc;

namespace GEARS.Controllers
{
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
            return View();
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
        {
            Course newCourse = new Course(session, type, degreeGroup, tuitCode, year);
            DueDateTime newDueDateTime = new DueDateTime(dueDate, dueTime, gradDueDate, gradDueTime);

            return View(newDueDateTime);
        }

        [HttpGet]
        public ActionResult Emails()
        {
            return View();
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
        {
            PreviewInfo newPreviewInfo = new PreviewInfo();

            return View(newPreviewInfo);
        }
    }
}