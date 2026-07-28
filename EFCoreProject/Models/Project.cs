using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Models
{
    public class Project
    {
        public int ProjectId {  get; set; }
        public string ProjectName { get; set; }
        public string ProjectLocation { get; set; }

        //many to many 
        // public List <Employee> employees { get; set; }
        public List<empProject> empProjects { get; set; }
    }
}
