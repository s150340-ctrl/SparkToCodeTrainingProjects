using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    [PrimaryKey(nameof(EmployeeId),nameof(ProjectId))]
    public class empProject
    {

        //1-M
        [ForeignKey("employee")]
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
        //1-M
        [ForeignKey("project")]
        public Project project { get; set; }
        public int ProjectId { get; set; }

        public int Hours { get; set; }

    }
}
