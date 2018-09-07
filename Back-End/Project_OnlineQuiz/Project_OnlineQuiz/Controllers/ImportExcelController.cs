using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using Project_OnlineQuiz.Models;

namespace Project_OnlineQuiz.Controllers
{
    public class ImportExcelController : Controller
    {
        // GET: ImportExcel
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ImportExcel importExcel)
        {
            if (ModelState.IsValid)
            {
                string path = Server.MapPath("~/Content/Upload/" + importExcel.file.FileName);
                importExcel.file.SaveAs(path);

                string excelConnectionString = @"Provider='Microsoft.ACE.OLEDB.12.0';Data Source='" + path + "';Extended Properties='Excel 12.0 Xml;IMEX=1'";
                OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);

                //Sheet Name
                excelConnection.Open();
                string tableName = excelConnection.GetSchema("Tables").Rows[0]["TABLE_NAME"].ToString();
                excelConnection.Close();
                //End

                OleDbCommand cmd = new OleDbCommand("Select * from [" + tableName + "]", excelConnection);

                excelConnection.Open();

                OleDbDataReader dReader;
                dReader = cmd.ExecuteReader();
                SqlBulkCopy sqlBulk = new SqlBulkCopy(ConfigurationManager.ConnectionStrings["DB_OnlineQuiz"].ConnectionString);

                //Give your Destination table name
                sqlBulk.DestinationTableName = "Questions";

                //Mappings
                sqlBulk.ColumnMappings.Add("CodeQuestion", "CodeQuestion");
                sqlBulk.ColumnMappings.Add("Text", "Text");
                sqlBulk.ColumnMappings.Add("Image", "Image");
                sqlBulk.ColumnMappings.Add("Type", "Type");
                sqlBulk.ColumnMappings.Add("Difficulty", "Difficulty");
                sqlBulk.ColumnMappings.Add("NumOfIterations", "NumOfIterations");
                sqlBulk.ColumnMappings.Add("CodeSubject", "CodeSubject");
                sqlBulk.ColumnMappings.Add("CodeTeacher", "CodeTeacher");
                sqlBulk.ColumnMappings.Add("CodeGeneralQuestion", "CodeGeneralQuestion");
                sqlBulk.ColumnMappings.Add("CodeChapter", "CodeChapter");

                sqlBulk.WriteToServer(dReader);
                excelConnection.Close();

                ViewBag.Result = "Successfully Imported";
            }
            return View();
        }

    }
}