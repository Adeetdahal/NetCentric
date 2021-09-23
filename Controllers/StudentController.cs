using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DAL;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using netcentricproject.Models;


namespace netcentricproject.Controllers
{
    public class StudentController : Controller
    {
        private readonly netcentricprojectDBContext context;
        public StudentController(netcentricprojectDBContext _context)
        {
            context = _context ?? throw new ArgumentNullException(nameof(_context));
        }

        [HttpGet("student")]
        public IActionResult ClassIndex()
        {
            string datasource = @"StudentDBConnection";
            List<StudentModel> classes = new List<StudentModel>();
            SqlConnection sqlConnection = new SqlConnection(datasource);

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Student", sqlConnection);//it is a sql command to execute in database
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // its a buffer to hold data from database
            DataTable dataTable = new DataTable(); //its is data type, like integer
            sqlDataAdapter.Fill(dataTable); //fill the datatable from the buffer
            sqlConnection.Close();
            return View("~/Views/Student/ClassIndex.cshtml");
            //return View(dataTable);
        }

        [HttpGet("student/table-data-view")]
        public async Task<IActionResult> GetAllStudents()
        {
            try
            {
                var data = await context.Students.ToListAsync();
                //var data = await context.Students.Where(e => e.Name.Contains(keyword)).ToListAsync();
                ViewData["StudentsList"] = data;
                return PartialView("~/Views/Student/Students.cshtml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public IActionResult AddUpdateClass(int? ClassId)
        {
            StudentModel classModel = new StudentModel();

            return View(classModel);
        }

        [HttpPost]
        public IActionResult AddUpdateClass(StudentModel classModel)
        {
            using (SqlConnection sqlConnection = new SqlConnection("StudentDBConnection"))
            {
                /*E:\Project\netcentricproject\netcentricproject\DAL\Database.mdf E:\\Project\\netcentricproject\\netcentricproject\\DAL\\Database.mdf;*/
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert into Student(Name,Roll) values ('" + classModel.Name + "', '" + classModel.Roll + "')", sqlConnection); //it is a sql command to execute in database
                int affectedRows = sqlCommand.ExecuteNonQuery();
                // sqlConnection.Close();
                return RedirectToAction("ClassIndex");
            }
        }

        public IActionResult Create()
        {

            return View(new StudentModel());
        }
        [HttpPost]
        public IActionResult Create(StudentModel student)
        {
            Student studentRow = new Student();
            studentRow.StudentId = student.StudentId;
            studentRow.Name = student.Name;
            studentRow.Roll = student.Roll;
            context.Students.Add(studentRow);
            context.SaveChanges();
            return RedirectToAction("Students");
        }
        public IActionResult Edit(int studentId)
        {
            StudentModel student = context.Students.Where(x => x.StudentId == studentId).Select(x => new StudentModel()
            {
                StudentId = x.StudentId,
                Name = x.Name,
                Roll = x.Roll,
            }).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(StudentModel student)
        {
            Student studentRow = new Student();
            studentRow.StudentId = student.StudentId;
            studentRow.Name = student.Name;
            studentRow.Roll = student.Roll;
            context.Students.Attach(studentRow);
            context.Entry(studentRow).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("students");
        }

        public IActionResult Delete(int StudentID)
        {
            StudentModel student = context.Students.Where(x => x.StudentId == StudentID).Select(x => new StudentModel()
            {
                StudentId = x.StudentId,
                Name = x.Name,
                Roll = x.Roll,
            }).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(StudentModel student)
        {
            Student studentRow = new Student();
            studentRow = context.Students.Where(x => x.StudentId == student.StudentId).FirstOrDefault();
            context.Students.Remove(studentRow);
            context.SaveChanges();
            return RedirectToAction("students");
        }



        public IActionResult Students()
        {
            List<StudentModel> students = context.Students.Select(student => new StudentModel()
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Roll = student.Roll,
            }).ToList();
            return View(students);
        }

        //public ActionResult search(string search) {

        //    using SqlConnection sqlConnection = new SqlConnection("StudentDBConnection");
        //    sqlConnection.Open();
        //    SqlCommand sqlCommand = new SqlCommand("Select * from Search_T where (Name like '%' + @name + '%')", sqlConnection);
        //    sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = search;//it is a sql command to execute in database
        //    sqlCommand.ExecuteNonQuery();
        //    // sqlConnection.Close();
        //    List<StudentModel> classes = new List<StudentModel>();
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // its a buffer to hold data from database
        //    DataTable dataTable = new DataTable(); //its is data type, like integer
        //    sqlDataAdapter.Fill(dataTable); //fill the datatable from the buffer
        //    //sqlConnection.Close();
        //    return View(dataTable);

        //}    

        //[HttpGet("employee/search")]
        //public async Task<IActionResult> SearchEmployee(string keyword)
        //{
        //    try
        //    {

        //        //var employees = await context.Students.Where(e => e.Name.ToLower().Contains(keyword.ToLower()));
        //        ViewData["EmployeesList"] = employees;
        //        return PartialView("~/Views/Student/Students.cshtml");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message); return null;
        //    }
        //}


    }


}