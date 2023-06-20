using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Vinyl.Models
{
    public partial class Uvarov_VinylContext : DbContext
    {
        public Uvarov_VinylContext()
        {
        }

        public Uvarov_VinylContext(DbContextOptions<Uvarov_VinylContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vinyl> Vinyls { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=lab116-p;Database=Uvarov_Vinyl;User Id=sa;Password=12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vinyl>(entity =>
            {
                entity.ToTable("Vinyl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Genre).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
