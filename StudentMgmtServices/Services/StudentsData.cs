using StudentMgmtServices.Data;
using StudentMgmtServices.Interfaces;
using StudentMgmtServices.Models;
using StudentMgmtServices.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMgmtServices.Services
{
    public class StudentsData : IStudents
    {
        private readonly StudentsMgmtSystemEntities _appdbContext;

        public StudentsData()
        {
            this._appdbContext = new StudentsMgmtSystemEntities();
        }

        public List<Students> GetAllStudents()
        {
            var students = _appdbContext.StudentsLists.ToList();

            List<Students> studList = new List<Students>();
            foreach (var item in students)
            {
                Students st = new Students
                {
                    Ssn = item.Ssn,
                    DistrictId = item.DistrictId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    DateOfBirth = item.DateOfBirth
                };
                studList.Add(st);
            }
            return studList;
        }

        public List<StudentEnrolledList> GetAllStudentEnrolledList()
        {
            List<StudentEnrolledList> enrolledList = new List<StudentEnrolledList>();
            var studentEnrolledList = (from s in _appdbContext.StudentsLists
                                       join r in _appdbContext.StudentEnrollments on s.Ssn equals r.StudentId

                                       select new
                                       {
                                           studentId = s.Ssn,
                                           s.FirstName,
                                           s.LastName,
                                           r.SchoolYear,
                                           r.StartDate,
                                           r.EndDate
                                       }).ToList();
            foreach (var item in studentEnrolledList)
            {
                enrolledList.Add(new StudentEnrolledList
                {
                    StudentId = item.studentId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    SchoolYear = item.SchoolYear,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate

                });
            }

            return enrolledList;
        }

        public List<StudentServicesInfo> GetAllStudentServices()
        {
            List<StudentServicesInfo> servicesInfo = new List<StudentServicesInfo>();
            var StudentServicesList = (from s in _appdbContext.StudentsLists
                                       join r in _appdbContext.StudentServices on s.Ssn equals r.StudentId

                                       select new
                                       {
                                           studentId = s.Ssn,
                                           s.FirstName,
                                           s.LastName,
                                           r.SchoolYear,
                                           r.StartDate,
                                           r.EndDate,
                                           r.ServiceName
                                       }).ToList();

            foreach (var item in StudentServicesList)
            {
                servicesInfo.Add(new StudentServicesInfo
                {
                    StudentId = item.studentId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    SchoolYear = item.SchoolYear,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate,
                    ServiceName = item.ServiceName

                });
            }

            return servicesInfo;
        }
    }
}