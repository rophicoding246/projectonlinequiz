using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDAO.EF;

namespace ModelDAO.DAO
{
    public class ChapterDAO
    {
        private OnlineQuizDBContext dbcontext = null;

        public ChapterDAO()
        {
            dbcontext = new OnlineQuizDBContext();
        }

        public List<Chapter> GetChaptersOfSubject(string codeSubject)
        {
            List<Chapter> chapters = dbcontext.Chapters.Where(n => n.CodeSubject == codeSubject).ToList();
            return chapters;
        }
    }
}
