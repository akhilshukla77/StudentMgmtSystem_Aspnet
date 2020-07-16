# StudentMgmtSystem_Aspnet
Create a simple Student Management System.
Add three Entities :
1) Student :
    Properties : DistrictId, FirstName , LastName, DateOfBirth, Ssn
2)Enrollment:
    Properties: StudentId, SchoolYear, StartDate, EndDate
3)Service:
    Properties: StudentId, SchoolYear, StartDate, EndDate

Add Three WebAPi :
1) To GetAllStudents which can be filtered by DistrictId
2) To GetAllStudentEnrollments by StudentId and can be filtered by SchoolYear
3) To GetAllStudentServices by StudentId and can be filtered by SchoolYear

Add the UI to pull and show data pulled from the Api's.
Prefer the UI Grid to have date field formatted to mm//dd/yyyy.

Technologies to be used:

1. MVC for UI
2. Web API and Entity Framework for Middle were
3. SQL Server (DataBase)


FAQ:

1) What is Ssn.
            this is just simple alphanumeric value.
2) There is no connection between Student and Enrollment.
             both table has student Id. Add student Id in Student table.
3) What is DistrictId.
          Its any numeric number from master table.
4) Entites Enrollment and Services are same then what is the use of service.
         Add ServiceName property in Service table.
5) different filtering option are there must be some connection among them
            All of them have studentid and based on that you need to fetch student data.
