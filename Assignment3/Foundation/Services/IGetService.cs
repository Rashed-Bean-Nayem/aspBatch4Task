using Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Services
{
    public interface IGetService
    {
        IList<Student> GetstudentList(); 
        IList<Course> GetcourseList();
        void RemoveAllData(StudentRegistration studentRegistration);
    }
}
