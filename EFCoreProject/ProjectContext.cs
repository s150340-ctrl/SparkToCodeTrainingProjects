using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class ProjectContext : DbContext
    {

        //1- register models
        public DbSet<Employee> employees {  get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<DepLocations> depLocations { get; set; }
        public DbSet<empProject> empProjects { get; set; }
        //2- connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=.\\SQLEXPRESS;Database=CompanyProjectDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

    }
}
