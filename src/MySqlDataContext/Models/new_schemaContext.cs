using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MySqlDataContext.Models
{
    public partial class new_schemaContext : DbContext
    {
        public new_schemaContext(DbContextOptions<new_schemaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cats> Cats { get; set; }
        public virtual DbSet<Dogs> Dogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=xxy;password=xxy@678.com;database=new_schema;TreatTinyAsBoolean=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cats>(entity =>
            {
                entity.ToTable("cats");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dogs>(entity =>
            {
                entity.ToTable("dogs");

                entity.Property(e => e.DeleteMark)
                    .HasColumnName("Delete_mark")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
