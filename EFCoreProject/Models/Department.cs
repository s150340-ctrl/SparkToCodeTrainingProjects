using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    public class Department
    {
        public int DepartmentId { get; set; } //1.2
        public int DepartmentNumber { get; set; }//10,20
        public string DepartmentName { get; set; }
        //works for
        [InverseProperty("D")]
        public List<Employee>  Employees { get; set; }



        //manages
        [ForeignKey("manager")]
        public int EmployeeId { get; set; }
        public Employee manager {  get; set; }
    }
}
