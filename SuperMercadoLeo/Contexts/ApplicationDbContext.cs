using Microsoft.EntityFrameworkCore;
using SuperMercadoLeo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMercadoLeo.Contexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        
        public DbSet<Branch> Branches {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Employee> Employees {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<Order_Detail> Order_Details {get; set;}
    }
}
