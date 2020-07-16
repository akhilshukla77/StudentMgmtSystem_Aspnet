using StudentMgmtServices.Models;
using StudentMgmtServices.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgmtServices.Interfaces
{
    public interface IStudents
    {
        List<Students> GetAllStudents();
        List<StudentEnrolledList> GetAllStudentEnrolledList();
        List<StudentServicesInfo> GetAllStudentServices();
    }
}
