using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fclasses
{
    public class Courses
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int DepartmentId { get; set; }  
        public List<Student> EnrolledStudents { get; set; }

        public void DisplayCourseInfo()
        {
            Console.WriteLine($"Course ID: {CourseId}, Course Name: {CourseName}, Department ID: {DepartmentId}");
            DisplayStudentCount();
        }

        private void DisplayStudentCount()
        {
            throw new NotImplementedException();
        }
    }
}
