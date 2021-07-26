using Microsoft.EntityFrameworkCore;
using MortalChicken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MortalChicken.Context
{
    public class ChickenDbContext: DbContext
    {
        public DbSet<Chicken> Chickens { get; set; }
        public DbSet<Farm> Farms { get; set; }

        public ChickenDbContext(DbContextOptions options) : base(options) { }
        public ChickenDbContext() { }

        
    }
}
