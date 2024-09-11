// See https://aka.ms/new-console-template for more information
using fclasses;

internal class Faculty
{
    public string FacultyName { get; set; }
    public int FacultyId { get; set; }
    public List<Department> Departments { get; set; }

    public void DisplayFacultyInfo()
    {
        Console.WriteLine(
            $"Faculty ID: {FacultyId}, " +
            $"Faculty Name: {FacultyName}");
        DisplayDepartmentCount();
    }
    private void DisplayDepartmentCount()
    {
        Console.WriteLine($"Number of Departments: {Departments.Count}");
    }
}