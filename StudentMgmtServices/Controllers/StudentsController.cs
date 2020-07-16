using StudentMgmtServices.Interfaces;
using StudentMgmtServices.Models;
using StudentMgmtServices.Services;
using StudentMgmtServices.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentMgmtServices.Controllers
{
    //[EnableCors(origins: "http://localhost:51574/", headers: "*", methods: "*")]
    public class StudentsController : ApiController
    {
        private readonly IStudents _students=null;

        public StudentsController(IStudents students)
        {
            this._students = students;
        }

        [HttpGet]      
        public IEnumerable<Students> GetAllStudents()
        {
            var result = _students.GetAllStudents().AsEnumerable();

            return result;

            //return Ok(_students.GetAllStudents());
        }

        [HttpGet]
        [Route("api/Students/GetAllStudents/{id}")]
        public IHttpActionResult GetStudentById(int id)
        {
            var student = _students.GetAllStudents().Where(x => x.DistrictId == id);
            if (student == null)
                return NotFound();
            return Ok(student);
        }

        [HttpGet]
        [Route("api/Students/GetAllStudentServices")]
        public IEnumerable<StudentServicesInfo> GetAllStudentServices()
        {
            var studentService = _students.GetAllStudentServices().AsEnumerable();

            return studentService;
        }

        [HttpGet]
        [Route("api/Students/GetAllStudentServices/{id}")]
        public IHttpActionResult GetStudentServiceById(int id)
        {
            var student = _students.GetAllStudentServices().Where(x => x.SchoolYear == id).ToList();
            if (student == null)
                return NotFound();
            return Ok(student);
        }

        [HttpGet]
        [Route("api/Students/GetAllStudentEnrolledList")]
        public IHttpActionResult GetAllStudentEnrolledList()
        {
            return Ok(_students.GetAllStudentEnrolledList());
        }

        [HttpGet]
        [Route("api/Students/GetAllStudentEnrolledList/{id}")]
        public IHttpActionResult GetStudentEnrolledByYear(int id)
        {
            var student = _students.GetAllStudentEnrolledList().Where(x => x.SchoolYear == id).ToList();
            if (student == null)
                return NotFound();
            return Ok(student);
        }

    }
}
