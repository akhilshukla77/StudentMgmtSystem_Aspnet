using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentMgmtServices.Models
{
    public class Students
    {
        public int Ssn { get; set; }
        public int DistrictId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[DateTimeParameter(DateFormat = "dd_MM_yyyy")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd_MM_yyyy}")]
        public DateTime DateOfBirth { get; set; }
    }
}