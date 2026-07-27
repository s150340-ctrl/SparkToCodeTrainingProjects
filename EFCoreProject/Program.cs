using EFCoreProject.Models;

namespace EFCoreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ProjectContext context = new ProjectContext();
            //add employee
            Employee e1 = new Employee();
            e1.EmployeeName = "Sara";
            e1.EmployeeSalary = 1;
            e1.EmployeeAge = 1;
            e1.EmployeeSsn = 1001;
            context.employees.Add(e1);
            context.SaveChanges();
        }
    }
}
