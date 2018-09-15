using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelDAO.DAO;
using ModelDAO.EF;

namespace ProjectOnlineQuiz_Web_v1.Areas.Teacher.Controllers
{
    public class QAndEBankTeacherController : Controller
    {
        // GET: Teacher/QAndEBankTeacher
        //Display List subject teaching
        public ActionResult Index() 
        {
            SubjectDAO subjectDAO = new SubjectDAO();
            List<Subject> subjects = subjectDAO.GetAllSubjects();
            return View(subjects);
        }

        //Display Chapters of the subject
        public ActionResult QuestionsExamsOfSubject(string codeSubject)
        {
            ChapterDAO chapterDAO = new ChapterDAO();
            List<Chapter> chapters = chapterDAO.GetChaptersOfSubject(codeSubject);
            return View(chapters);
        }

        public ActionResult _QuestionsOfSubject(string codeSubject)
        {
            QuestionDAO questionDAO = new QuestionDAO();
            List<Question> questions = questionDAO.GetQuestionsOfSubject(codeSubject);
            return PartialView(questions);
        }

        public ActionResult _QuestionsOfChapter(string codeChapter)
        {
            QuestionDAO questionDAO = new QuestionDAO();
            List<Question> questions = questionDAO.GetQuestionsOfChapter(codeChapter);
            return PartialView(questions);
        }

        public ActionResult _AnswersOfQuestion(string codeQuestion)
        {
            AnswerDAO answerDAO = new AnswerDAO();
            List<Answer> answers = answerDAO.GetAnswersOfQuestion(codeQuestion);
            return PartialView(answers);
        }

    }
}