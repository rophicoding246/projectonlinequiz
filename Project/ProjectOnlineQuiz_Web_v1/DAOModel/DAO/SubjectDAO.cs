using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOModel.EF;
using DAOModel.ViewModel;

namespace DAOModel.DAO
{
    public class SubjectDAO
    {
        private OnlineQuizDBContext dbcontext = null;

        public SubjectDAO()
        {
            dbcontext = new OnlineQuizDBContext();
        }

        public List<Subject> ListSubjectAll()
        {
            List<Subject> listSubject = dbcontext.Subjects.Select(n=>n).ToList();
            return listSubject;
        }

        public List<DetailSubjectTeaching> ListSubjectTeaching(string idTeacher)
        {
            //Object parameters = new ObjectParameter("@CodeTeacher", idTeacher);

            List<DetailSubjectTeaching> listSubject = dbcontext.Database.SqlQuery<DetailSubjectTeaching>("exec prc_ListSubjectTeaching @CodeTeacher", new SqlParameter("@CodeTeacher", idTeacher)).ToList();
            return listSubject;
        }
    }
}
