using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDAO.EF;

namespace ModelDAO.DAO
{
    public class QuestionDAO
    {
        private OnlineQuizDBContext dbcontext = null;

        public QuestionDAO()
        {
            dbcontext = new OnlineQuizDBContext();
        }

        public List<Question> GetQuestionsOfSubject(string codeSubject)
        {
            List<Question>  questions = dbcontext.Questions.Where(n => n.CodeSubject == codeSubject).ToList();
            return questions;
        }

        public List<Question> GetQuestionsOfChapter(string codeChapter)
        {
            List<Question> questions = dbcontext.Questions.Where(n => n.CodeChapter == codeChapter).ToList();
            return questions;
        }
    }
}
