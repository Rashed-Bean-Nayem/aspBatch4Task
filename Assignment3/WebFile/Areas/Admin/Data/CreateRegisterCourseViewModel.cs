//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace WebFile.Areas.Admin.Data
//{
//    public class CreateRegisterCourseViewModel
//    {
//        private readonly IRegistrationService _registrationService;

//        public IList<Student> Students { get; set; }
//        public IList<Course> Courses { get; set; }

//        [Required]
//        public int StudentId { get; set; }

//        [Required]
//        public int CourseId { get; set; }

//        [Display(Name = "Payment")]
//        public bool IsPaymentComplete { get; set; }

//        public CreateRegisterCourseViewModel(IRegistrationService registrationService)
//        {
//            _registrationService = registrationService;
//        }

//        public CreateRegisterCourseViewModel()
//        {
//            _registrationService = Startup.AutofacContainer.Resolve<IRegistrationService>();
//        }

//        public void AddRegisterCourse()
//        {
//            var registerCourse = new StudentRegistration
//            {
//                StudentId = this.StudentId,
//                CourseId = this.CourseId,
//                EnrollDate = DateTime.Now,
//                IsPaymentComplete = this.IsPaymentComplete
//            };

//            _registrationService.AddStudentRegistration(registerCourse);
//        }

//        public void LoadStudents()
//        {
//            Students = _registrationService.GetStudents();
//        }

//        public void LoadCourses()
//        {
//            Courses = _registrationService.GetCourses();
//        }
//    }
//}
