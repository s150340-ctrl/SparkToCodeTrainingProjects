using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreProject.Models
{
    [PrimaryKey(nameof(DepartmentId), nameof(locations))]
    public  class DepLocations
    {
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        //here
        public string locations { get; set; }
    }
}
