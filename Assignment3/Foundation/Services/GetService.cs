using Foundation.Entities;
using Foundation.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Services
{
    public class GetService : IGetService
    {
        private readonly IRegistrationUnitOfWork _shopingUnitOfWork;


        public GetService(IRegistrationUnitOfWork shopingUnitOfWork)
        {
            _shopingUnitOfWork = shopingUnitOfWork;
        }


        public IList<Student> GetstudentList() 
        {
            return _shopingUnitOfWork.StudentRepository.GetAll();
        }
        public IList<Course> GetcourseList() 
        {
            return _shopingUnitOfWork.CourseRepository.GetAll();
        }

        
        public void RemoveAllData(StudentRegistration studentRegistration)
        {
            _shopingUnitOfWork.RegistrationRepository.Remove(studentRegistration);
        }

        
    }
}
