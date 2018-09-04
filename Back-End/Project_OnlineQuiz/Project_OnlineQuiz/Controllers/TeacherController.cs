using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_OnlineQuiz.Models;

namespace Project_OnlineQuiz.Controllers
{
    public class TeacherController : Controller
    {
        DB_OnlineQuizEntities db_onlinequiz = new DB_OnlineQuizEntities();

        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListSubject()
        {
            List<TeachingSubject> listSubject = db_onlinequiz.TeachingSubjects.Select(n => n).ToList();
            return PartialView(listSubject);
        }
    }
}