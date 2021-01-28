using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IO_Ders_3___Template.Models.Mapping
{
    public class Biten_Urunler_ListesiMap : EntityTypeConfiguration<Biten_Urunler_Listesi>
    {
        public Biten_Urunler_ListesiMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UrunID, t.UrunAdi });

            // Properties
            this.Property(t => t.UrunID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UrunAdi)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("Biten Urunler Listesi");
            this.Property(t => t.UrunID).HasColumnName("UrunID");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
        }
    }
}
