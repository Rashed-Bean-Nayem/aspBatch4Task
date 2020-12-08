using Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Services
{
    public interface IAddingService
    {
        void AddStudent(Student student); 
        void AddCourse(Course course); 

    }
}
