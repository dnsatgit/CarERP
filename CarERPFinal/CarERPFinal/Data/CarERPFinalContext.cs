using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarERPFinal.Models;

namespace CarERPFinal.Models
{
    public class CarERPFinalContext : DbContext
    {
        public CarERPFinalContext (DbContextOptions<CarERPFinalContext> options)
            : base(options)
        {
        }

        public DbSet<CarERPFinal.Models.Services> Services { get; set; }

        public DbSet<CarERPFinal.Models.Customer> Customer { get; set; }

        public DbSet<CarERPFinal.Models.Request> Request { get; set; }

        public DbSet<CarERPFinal.Models.Employee> Employee { get; set; }
    }
}
