using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject
{
    public class ProjectContext : DbContext
    {
        //set db for lists
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }

    }
}
