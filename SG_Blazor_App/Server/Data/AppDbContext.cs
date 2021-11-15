using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SG_Blazor_App.Shared.Models;
using SG_Blazor_App.Shared.Models.ConAte;

namespace SG_Blazor_App.Server.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AtencionModel> Atenciones { get; set; } = null!;
        public DbSet<InterconsultaModel> interconsultas { get; set; }
        public DbSet<AdmisionModel> admisions { get; set; }
        public DbSet<EspecialidadMedicaModel> especialidadMedica { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AtencionModel>(entity =>
            {
                entity.HasKey(e => e.IdAtenciones)
                    .HasName("PK_dbo.Atenciones");
            });

            modelBuilder.Entity<AtencionModel>()
                .HasMany(b => b.interconsultas)
                .WithOne().HasForeignKey(c => c.IdAtenciones);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
