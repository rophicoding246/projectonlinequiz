using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
using System.IO;

namespace Project_OnlineQuiz.Controllers
{
    public class addImportExcController : Controller
    {
        // GET: addImportExc
        //tạo chuỗi connect
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_OnlineQuizEntities"].ConnectionString);
        OleDbConnection Econ;
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            string filename = Guid.NewGuid() + Path.GetExtension(file.FileName);
            string filepath = "/Excelfolder/" + filename;
            file.SaveAs(Path.Combine(Server.MapPath("/Excelfolder/"), filename));
            insertExceldata(filepath,filename);
                return View();
        }
        private void ExcelConn(string filepath)
        {
            string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={0};Extended Properties=""Excel 16.0 xml;HDR=YES;""", filepath);
            Econ = new OleDbConnection(constr);
        }
        private void insertExceldata( string filepath,string filename)
        {
            string fullpath = Server.MapPath("/Excelfolder/") + filename;
            ExcelConn(fullpath);
            string query = string.Format("Select * from [{0}]", "Sheet1$");
            OleDbCommand Ecom = new OleDbCommand(query, Econ);
            Econ.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter oda = new OleDbDataAdapter(query,Econ);
            Econ.Close();
            oda.Fill(ds);

            DataTable dt = ds.Tables[0];
            SqlBulkCopy objbulk = new SqlBulkCopy(con);
            objbulk.DestinationTableName = "Questions";
          //  objbulk.ColumnMappings.Add("CodeQuestion", "CodeQuestion");
            objbulk.ColumnMappings.Add("Text", "Text");
            objbulk.ColumnMappings.Add("Image", "Image");
            objbulk.ColumnMappings.Add("Type", "Type");
            objbulk.ColumnMappings.Add("Difficulty", "Difficulty");
            objbulk.ColumnMappings.Add("NumOflterations", "NumOflterations");
            objbulk.ColumnMappings.Add("CodeSubject", "CodeSubject");
            objbulk.ColumnMappings.Add("CodeTeacher", "CodeTeacher");
            objbulk.ColumnMappings.Add("CodeGeneralQuetion", "CodeGeneralQuetion");
            objbulk.ColumnMappings.Add("CodeChapter", "CodeChapter");
            con.Open();
            objbulk.WriteToServer(dt);
            con.Close();


        }
    }
}