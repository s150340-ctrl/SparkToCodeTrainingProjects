using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task_8_EF.Models;

namespace Task_8_EF
{
    public class ProjectContext : DbContext
    {


        //1- register models

        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<ProdOrder> prodOrders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Review > reviews { get; set; }
        public DbSet<User> users { get; set; }

        //2- we connect to server
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=.\\SQLEXPRESS;Database=OrderSimulaterDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
