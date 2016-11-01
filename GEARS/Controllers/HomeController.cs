using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GEARS.Models;
using GEARS.Helpers;

namespace GEARS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
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
        public String Query(QueryPageModel search)
        {
            //STUB
            DBHelper db = new DBHelper();
            DueDates result = db.FindDueDatesByQuery(search.Course.Query);
            String editDueDatesPartial = PartialView("_DueDatesPartial", result).RenderToString();
            return editDueDatesPartial;
        }

        [HttpPost]
        public String SaveDates(Course course)
        {
            //STUB
            DBHelper db = new DBHelper();
            String result = db.SaveDueDates(course.Query, course.DueDates);
            return result;
        }

        [HttpPost]
        public String Emails(QueryPageModel search)
        {
            //STUB
            DBHelper db = new DBHelper();
            List<Course> result = db.FindCoursesByQuery(search.Course.Query);
            Email em = new Email();
            em.Courses = result;
            String emailsPartial = PartialView("_EmailsPartial", em).RenderToString();
            return emailsPartial;
        }
    }
}