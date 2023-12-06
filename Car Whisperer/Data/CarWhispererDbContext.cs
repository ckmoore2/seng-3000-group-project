using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Car_Whisperer;
using Car_Whisperer.Entities;
using  Car_Whisperer.Controllers;

namespace Car_Whisperer.Data;

public class CarWhispererDbContext : DbContext
    {
        public CarWhispererDbContext (DbContextOptions<CarWhispererDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Tire> Tires { get; set; } = null!;
    }
