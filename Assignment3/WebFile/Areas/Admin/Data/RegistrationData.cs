using Autofac;
using Foundation.Entities;
using Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFile.Areas.Admin.Data
{
    public class RegistrationData
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollDate { get; set; }
        public bool IsPaymentComplete { get; set; }
        public int Id { get; set; }
        public IList<Student> Students { get; set; }
        public IList<Course> Courses { get; set; }

        private readonly IGetService _getService;


        public RegistrationData(IGetService getService)
        {

            _getService = getService;

        }
        public RegistrationData()
        {

            _getService = Startup.AutofacContainer.Resolve<IGetService>();

        }
      
        public void LoadStudents()
        {
            Students = _getService.GetstudentList();
        }

        public void LoadCourses()
        {
            Courses = _getService.GetcourseList();
        }
    }
}
