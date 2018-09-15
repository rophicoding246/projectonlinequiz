using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDAO.EF;

namespace ModelDAO.DAO
{
    public class SubjectDAO
    {
        private OnlineQuizDBContext dbcontext = null;

        public SubjectDAO()
        {
            dbcontext = new OnlineQuizDBContext();
        }

        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = dbcontext.Subjects.Select(n => n).ToList();
            return subjects;
        }

        //public List<DetailSubjectTeaching> ListSubjectTeaching(string idTeacher)
        //{
        //    List<DetailSubjectTeaching> listSubject = dbcontext.Database.SqlQuery<DetailSubjectTeaching>("exec prc_ListSubjectTeaching @CodeTeacher", new SqlParameter("@CodeTeacher", idTeacher)).ToList();
        //    return listSubject;
        //}
    }
}
