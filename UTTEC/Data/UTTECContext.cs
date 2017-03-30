using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UTTEC.Models;

namespace UTTEC.Data
{
    public class UTTECContext:DbContext
    {
        public UTTECContext(DbContextOptions<UTTECContext> options):base(options)
        {
        }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Profesor> Profesor { get; set; }        
        public DbSet<Grado> Grado { get; set; }
        public DbSet<Materia> Materia { get; set; }    
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumnos>().ToTable("Alumnos");
            modelBuilder.Entity<Grado>().ToTable("Grado");
            modelBuilder.Entity<Materia>().ToTable("materia");
            modelBuilder.Entity<Profesor>().ToTable("profesor");            
        }

    }
}
