using Microsoft.EntityFrameworkCore;

namespace OracleDataContext.Models
{
    public partial class CARGOContext : DbContext
    {
        public virtual DbSet<EntityIdentified> EntityIdentified { get; set; }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityIdentified>(entity =>
            {
                entity.HasNoKey();
                entity.ToView(null);
                entity.Property(v => v.ID).HasColumnType("NUMBER");
            });
        }
    }

    public class EntityIdentified
    {
        public decimal ID { get; set; }
    }
}
