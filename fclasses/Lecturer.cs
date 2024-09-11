using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fclasses
{
    public class Lecturer
    {
        public string LecturerName { get; set; }
        public Guid LecturerId { get; set; }
        public Guid DepartmentId { get;  set; }
        public void DisplayLecturerInfo()
        {
            Console.WriteLine(
                $"Lecturer ID: {LecturerId}," +
                $" Lecturer Name: {LecturerName}," +
                $" Department ID: {DepartmentId}");

        }
    }
}
