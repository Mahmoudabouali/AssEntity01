using AssEntity01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEntity01.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("server = .;database = AssAirLine;trusted_Connection = true; trust server certificate = true");
        }

        public DbSet<AirCraft> AirCrafts { get; set; }
        public DbSet<AirLine> AirLine { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<AirLinePhones> AirLinePhones { get; set;}
        public DbSet<EmpQualification> EmpQualifications { get; set; }
        public DbSet<AirCraftRoute> AirCraftRoute { get; set; }

    }
}
