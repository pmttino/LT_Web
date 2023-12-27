using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tinoshop_demo2.Models;

namespace tinoshop_demo2.Data
{
    public class tinoshop_demo2Context : DbContext
    {
        public tinoshop_demo2Context (DbContextOptions<tinoshop_demo2Context> options)
            : base(options)
        {
        }

        public DbSet<tinoshop_demo2.Models.User> User { get; set; } = default!;

        public DbSet<tinoshop_demo2.Models.Category>? Category { get; set; }

        public DbSet<tinoshop_demo2.Models.Product>? Product { get; set; }
    }
}
