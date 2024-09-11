using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fclasses
{
    public class Department
    {
        public Guid DepartmentId {  get; set; }
        public string DepartmentName { get; set; }
        public Guid FacultyId { get; set; }
        public string FacultyName { get;set; }

        public void DisplayDepartmentInfo ()
        {
            Console.WriteLine(
                $"DepartmentId {DepartmentId}",
                $"DepartmentName {DepartmentName}",
                $"FacultyId {FacultyId}",
                $"FacultyName {FacultyName}"
                );
        }
    }
}
