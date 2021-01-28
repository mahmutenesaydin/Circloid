using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IO_Ders_3___Template.Models.Mapping
{
    public class Sehirlere_Gore_Musteri_ve_TedarikcilerMap : EntityTypeConfiguration<Sehirlere_Gore_Musteri_ve_Tedarikciler>
    {
        public Sehirlere_Gore_Musteri_ve_TedarikcilerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SirketAdi, t.Relationship });

            // Properties
            this.Property(t => t.Sehir)
                .HasMaxLength(15);

            this.Property(t => t.SirketAdi)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.MusteriAdi)
                .HasMaxLength(30);

            this.Property(t => t.Relationship)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("Sehirlere Gore Musteri ve Tedarikciler");
            this.Property(t => t.Sehir).HasColumnName("Sehir");
            this.Property(t => t.SirketAdi).HasColumnName("SirketAdi");
            this.Property(t => t.MusteriAdi).HasColumnName("MusteriAdi");
            this.Property(t => t.Relationship).HasColumnName("Relationship");
        }
    }
}
