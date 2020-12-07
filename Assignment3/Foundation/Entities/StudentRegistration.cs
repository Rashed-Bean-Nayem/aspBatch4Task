using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Entities
{
    public class StudentRegistration: IEntity<int>
    {
        public int StudentId { get; set; } 
        public Student Student { get; set; } 
        public int CourseId { get; set; } 
        public Course Course { get; set; } 
        public DateTime EnrollDate { get; set; } 
        public bool IsPaymentComplete { get; set; }
        public int Id { get ; set ; }
    }
}
