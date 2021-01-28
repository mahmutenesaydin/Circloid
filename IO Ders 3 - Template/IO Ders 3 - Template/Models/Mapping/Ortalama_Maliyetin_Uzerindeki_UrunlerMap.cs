using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IO_Ders_3___Template.Models.Mapping
{
    public class Ortalama_Maliyetin_Uzerindeki_UrunlerMap : EntityTypeConfiguration<Ortalama_Maliyetin_Uzerindeki_Urunler>
    {
        public Ortalama_Maliyetin_Uzerindeki_UrunlerMap()
        {
            // Primary Key
            this.HasKey(t => t.UrunAdi);

            // Properties
            this.Property(t => t.UrunAdi)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("Ortalama Maliyetin Uzerindeki Urunler");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.BirimFiyati).HasColumnName("BirimFiyati");
        }
    }
}
