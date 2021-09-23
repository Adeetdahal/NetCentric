using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace netcentricproject.Controllers
{
    public class Search : Controller
    {
        private readonly netcentricprojectDBContext _db;

        public Search(netcentricprojectDBContext db)
        {
            _db = db;
        }

        [HttpGet("Student")]
        public IActionResult Index()
        {
            return View("~/Views/Student/Students.cshtml");
        }
        //public async Task<IActionResult> SearchEmployee(string keyword)
        //{
        //    {

        //        using (SqlConnection sqlConnection = new SqlConnection("StudentDBConnection"))
        //        {
        //            sqlConnection.Open();
        //            SqlCommand sqlCommand = new SqlCommand("selcect * from Search_T where(Name like '%' +@name + '%' )", sqlConnection);
        //            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = keyword;
        //            sqlCommand.ExecuteNonQuery();
        //            SqlDataAdapter da = new SqlDataAdapter();
        //            da.SelectCommand = sqlCommand;
        //            DataSet ds = new DataSet();
        //            da.Fill(ds, "Name");
        //            ViewData["search_employee"] = employees;
        //            PartialView("~/Views/Student/Students.cshtml");
        //            // sqlConnection.Close();

        //        }
        //    }

        //[HttpGet("employee/table-data-view")]
        //public async Task<IActionResult> GetAllEmployees()
        //{
        //    try
        //    {
        //        var data = await _db.Students.ToListAsync();
        //        ViewData["EmployeesList"] = data;
        //        return PartialView("~/Views/Employee/_TableData.cshtml");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return null;
        //    }
        //}

        public async Task<IActionResult> SearchEmployee(string keyword)
        {
            try
            {
                var employees = await _db.Students.Where(e => e.Name.Contains(keyword)).ToListAsync();
                ViewData["EmployeesList"] = employees;
                return PartialView("~/Views/Employee/_TableData.cshtml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); return null;
            }
        }

    }
    }




