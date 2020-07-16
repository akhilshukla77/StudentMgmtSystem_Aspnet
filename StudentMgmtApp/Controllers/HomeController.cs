using Newtonsoft.Json;
using StudentMgmtApp.Helper;
using StudentMgmtApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace StudentMgmtApp.Controllers
{
    public class HomeController : Controller
    {
        StudentMgmtApi _api = null;
        public HomeController()
        {
            _api = new StudentMgmtApi();
        }

        public async Task<ActionResult> Index()
        {
            List<Students> students = new List<Students>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Students/GetAllStudents");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<Students>>(results);
            }
            ViewBag.showResult = false;
            return View(students);
        }

        public async Task<ActionResult> FilterStudents(string SearchString)
        {
            ViewData["CurrentFilter"] = SearchString;
            ViewBag.showResult = true;

            List<Students> students = new List<Students>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Students/GetAllStudents/" + Convert.ToInt32(SearchString));
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<Students>>(results);
            }
            //return View(students);
            return View("FilterStudents", students);
        }

        public async Task<ActionResult> Enrollments()
        {
            List<StudentEnrolled> students = new List<StudentEnrolled>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Students/GetAllStudentEnrolledList");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<StudentEnrolled>>(results);
            }
            ViewBag.showResult = false;
            return View(students);
        }

        public async Task<ActionResult> FilterEnrollments(string SearchString)
        {
            ViewData["CurrentFilter"] = SearchString;

            List<StudentEnrolled> students = new List<StudentEnrolled>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Students/GetAllStudentEnrolledList/" + Convert.ToInt32(SearchString));
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<StudentEnrolled>>(results);
            }
            //return View(students);
            ViewBag.showResult = true;
            return View("FilterEnrollments", students);
        }


        public async Task<ActionResult> StudentServices()
        {
            List<StudentServices> students = new List<StudentServices>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Students/GetAllStudentServices");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<StudentServices>>(results);
            }

            ViewBag.showResult = false;
            return View(students);
        }

        public async Task<ActionResult> FilterStudentServices(string SearchString)
        {
            ViewData["CurrentFilter"] = SearchString;

            List<StudentServices> students = new List<StudentServices>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Students/GetAllStudentServices/" + Convert.ToInt32(SearchString));
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<StudentServices>>(results);
            }
            ViewBag.showResult = true;

            return View("FilterStudentServices", students);
        }
    }
}