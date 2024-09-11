using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fclasses
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid FacultyId { get; set; }
        

        public void DisplayStudentInfo ()
        {
            Console.WriteLine(
                $"StudentId: {StudentId}, " +
                $"Studentname: {StudentName}," +
                $"Department: {DepartmentId}," +
                $"Faculty: {FacultyId}, ");
        }
       
    }

}
