using System.Web.Mvc;

namespace ProjectOnlineQuiz_Web_v1.Areas.Teacher
{
    public class TeacherAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Teacher";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Teacher_default",
                "GiangVien/{controller}/{action}/{id}",
                new { controller = "HomeTeacher", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}