using Foundation.Entities;
using Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFile.Areas.Admin.Data;

namespace WebFile.Models
{
    public class IndexModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

   
        private readonly IAddingService _addingService;


        public IndexModel(IAddingService addingService)
        {

            _addingService = addingService;
        }
        public void AddModelStudent(StudentData studentData) 
        {
            _addingService.AddStudent(new Student
            {

                Name = studentData.Name,
                DateOfBirth = studentData.DateOfBirth

            });
        }
        public void AddModelCourse(CourseData courseData) 
        {
            _addingService.AddCourse(new Course
            {

               Title=courseData.Title,
               SeatCount=courseData.SeatCount,
               Fee=courseData.Fee

            });
        }

       public void AddModelRegistration(RegistrationData registrationData) 
        {
            _addingService.AddRegistration(new StudentRegistration
            {

                StudentId=registrationData.StudentId,
                CourseId=registrationData.CourseId,
                EnrollDate=registrationData.EnrollDate,
                IsPaymentComplete=registrationData.IsPaymentComplete

            });
        }

        public IList<StudentData> GetStudentsList()
        {
            List<StudentData> studentDataList = new List<StudentData>();
            return studentDataList;
        }
    }
}
