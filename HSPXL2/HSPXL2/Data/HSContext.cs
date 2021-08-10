using HSPXL2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Data
{
    public class HSContext : DbContext
    {
        public HSContext(DbContextOptions<HSContext> opts) : base(opts)
        {               
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Cursus> Cursus { get; set; }
        public DbSet<Handboek> Handboeks { get; set; }
        public DbSet<Inschrijving> Inschrijvings { get; set; }


    }
}
