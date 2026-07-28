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
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public double EmployeeSalary { get; set; }
        //works for
        [ForeignKey("D")]
        public int DepartmentId { get; set; }

        public Department D {  get; set; }
    }
}
