// See https://aka.ms/new-console-template for more information
using System.CodeDom.Compiler;
using fclasses;
Faculty faculty2 = new Faculty
{
    FacultyId = 1,
    FacultyName = "Faculty of Science",
    Departments = new List<Department>()
};
Faculty faculty1 = new Faculty
{
    FacultyId = 1,
    FacultyName = "Faculty of Education",
    Departments = new List<Department>()
};

Department department1 = new Department
{
    DepartmentId = Guid.NewGuid(),
    DepartmentName = "Computer Science",
    FacultyId = Guid.NewGuid()
};

Department department2 = new Department
{
    DepartmentId = Guid.NewGuid(),
    DepartmentName = "Computer Science",
    FacultyId = Guid.NewGuid()
};

faculty1.Departments.Add(department1);
faculty2.Departments.Add(department2);

Lecturer lecturer1 = new Lecturer { 
    LecturerId = Guid.NewGuid(),
    LecturerName = "Dr. Smith",
    DepartmentId = Guid.NewGuid()
};
Lecturer lecturer2 = new Lecturer {
    LecturerId = Guid.NewGuid(),
    LecturerName = "Dr. Jones", 
    DepartmentId = Guid.NewGuid()
};

Student student1 = new Student {
    StudentId = Guid.NewGuid(),
    StudentName = "Alice", 
    DepartmentId = Guid.NewGuid(), 
    FacultyId = Guid.NewGuid()
};
Student student2 = new Student { 
    StudentId = Guid.NewGuid(),
    StudentName = "Bob", 
    DepartmentId = Guid.NewGuid(), 
    FacultyId = Guid.NewGuid() 
};

Courses course1 = new Courses {
    CourseId = 1,
    CourseName = "Data Structures", 
    DepartmentId = 1,
    EnrolledStudents = new List<Student> { student1 }
};

Courses course2 = new Courses { 
    CourseId = 2,
    CourseName = "Thermodynamics",
    DepartmentId = 2, 
    EnrolledStudents = new List<Student> { student2 } 
};

faculty1.DisplayFacultyInfo();
faculty2.DisplayFacultyInfo();

department1.DisplayDepartmentInfo();
department2.DisplayDepartmentInfo();

student1.DisplayStudentInfo();
student2.DisplayStudentInfo();

course1.EnrolledStudents.Add(student1);



