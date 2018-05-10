using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarERPv2.Models;

namespace CarERPv2.Models
{
    public class CarERPv2Context : DbContext
    {
        public CarERPv2Context (DbContextOptions<CarERPv2Context> options)
            : base(options)
        {
        }

        public DbSet<CarERPv2.Models.Customer> Customer { get; set; }

        public DbSet<CarERPv2.Models.Employee> Employee { get; set; }

        public DbSet<CarERPv2.Models.Item> Item { get; set; }

        public DbSet<CarERPv2.Models.Request> Request { get; set; }

        public DbSet<CarERPv2.Models.Services> Services { get; set; }
    }
}
