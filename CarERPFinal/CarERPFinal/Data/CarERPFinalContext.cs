using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarERPFinal.Models
{
    public class CarERPFinalContext : DbContext
    {
        public CarERPFinalContext (DbContextOptions<CarERPFinalContext> options)
            : base(options)
        {
        }

        public DbSet<CarERPFinal.Models.Services> Services { get; set; }
    }
}
