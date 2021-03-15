using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MySqlDataContext.Models
{
    public partial class new_schemaContext : DbContext
    {
        public new_schemaContext()
        {
        }

        public new_schemaContext(DbContextOptions<new_schemaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<cats> cats { get; set; }
        public virtual DbSet<dogs> dogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=192.168.0.46;port=13306;user=xxy;password=xxy@678.com;database=new_schema;TreatTinyAsBoolean=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cats>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<dogs>(entity =>
            {
                entity.Property(e => e.DeleteMark).HasColumnType("bit(1)");

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
