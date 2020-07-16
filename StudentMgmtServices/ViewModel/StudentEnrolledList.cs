using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMgmtServices.ViewModel
{
    public class StudentEnrolledList
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SchoolYear { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}