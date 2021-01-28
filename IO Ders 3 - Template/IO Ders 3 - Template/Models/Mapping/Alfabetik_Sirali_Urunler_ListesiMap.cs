using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IO_Ders_3___Template.Models.Mapping
{
    public class Alfabetik_Sirali_Urunler_ListesiMap : EntityTypeConfiguration<Alfabetik_Sirali_Urunler_Listesi>
    {
        public Alfabetik_Sirali_Urunler_ListesiMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UrunID, t.UrunAdi, t.Sonlandi, t.KategoriAdi });

            // Properties
            this.Property(t => t.UrunID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UrunAdi)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.BirimdekiMiktar)
                .HasMaxLength(20);

            this.Property(t => t.KategoriAdi)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Alfabetik Sirali Urunler Listesi");
            this.Property(t => t.UrunID).HasColumnName("UrunID");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.TedarikciID).HasColumnName("TedarikciID");
            this.Property(t => t.KategoriID).HasColumnName("KategoriID");
            this.Property(t => t.BirimdekiMiktar).HasColumnName("BirimdekiMiktar");
            this.Property(t => t.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(t => t.HedefStokDuzeyi).HasColumnName("HedefStokDuzeyi");
            this.Property(t => t.YeniSatis).HasColumnName("YeniSatis");
            this.Property(t => t.EnAzYenidenSatisMikatari).HasColumnName("EnAzYenidenSatisMikatari");
            this.Property(t => t.Sonlandi).HasColumnName("Sonlandi");
            this.Property(t => t.KategoriAdi).HasColumnName("KategoriAdi");
        }
    }
}
