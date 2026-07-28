using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;         // Added for [Key] if needed
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreProject.Models
{
    public class Employee
    {
        public int EmployeeSsn {  get; set; }
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public double EmployeeSalary { get; set; }
        //works for
        [ForeignKey("D")]
        public int DepartmentId { get; set; }

        public Department D {  get; set; }
        //many to many (works on)-
       // public List<Project> projects { get; set; }

        //works on
        public List<empProject> emp { get; set; }

        //manages
        [InverseProperty("manager")]
        public Department mangedDepartment { get; set; }


        //supervision 1-M self relationship
        [InverseProperty("superviser")]
        public List<Employee> supervisee {  get; set; }
        [ForeignKey("superviser")]
        public int SuperviseId { get; set; }
        public Employee superviser {  get; set; }
    }
}
