using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAOModel.DAO;

namespace ProjectOnlineQuiz_Web_v1.Areas.Teacher.Controllers
{
    public class BankQuestionsController : Controller
    {
        // GET: Teacher/BankQuestions
        public ActionResult Index()
        {
            SubjectDAO subject = new SubjectDAO();
            return View(subject.ListSubjectTeaching("GV00001"));
        }
    }
}