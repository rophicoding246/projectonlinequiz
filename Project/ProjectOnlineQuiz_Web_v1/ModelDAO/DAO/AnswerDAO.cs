using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDAO.EF;

namespace ModelDAO.DAO
{
    public class AnswerDAO
    {
        private OnlineQuizDBContext dbcontext = null;

        public AnswerDAO()
        {
            dbcontext = new OnlineQuizDBContext();
        }

        public List<Answer> GetAnswersOfQuestion(string codeQuestion)
        {
            List<Answer> answers = dbcontext.Answers.Where(n => n.CodeQuestion == codeQuestion).ToList();
            return answers;
        }
    }
}
