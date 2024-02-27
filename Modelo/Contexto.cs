using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection.Emit;

namespace Modelo
{
    public class Contexto : DbContext
    {
        public Contexto() : base()
        {
        }

        public DbSet<Investigador> Investigadores { get; set; }
        public DbSet<Convocatoria> Convocatorias { get; set; }
        public DbSet<Investigacion> Investigaciones { get; set; }
        public DbSet<Proyecto> Proyectos{ get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConfigurationManager.ConnectionStrings["GestionProyectoInvestigacion"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Investigacion>()
                .HasMany(e => e.Investigadores)
                .WithOne(e => e.Investigacion)
                .HasForeignKey(e => e.IdInvestigacion);

            builder.Entity<Convocatoria>()
                .HasMany(e => e.Investigadores)
                .WithOne(e => e.Convocatoria)
                .HasForeignKey(e => e.IdConvocatoria);

            builder.Entity<Proyecto>()
                .HasMany(e => e.Convocatorias)
                .WithOne(e => e.Proyecto)
                .HasForeignKey(e => e.IdProyecto);
        }
    }
}