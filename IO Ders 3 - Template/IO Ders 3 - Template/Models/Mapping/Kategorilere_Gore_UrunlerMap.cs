using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IO_Ders_3___Template.Models.Mapping
{
    public class Kategorilere_Gore_UrunlerMap : EntityTypeConfiguration<Kategorilere_Gore_Urunler>
    {
        public Kategorilere_Gore_UrunlerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.KategoriAdi, t.UrunAdi, t.Sonlandi });

            // Properties
            this.Property(t => t.KategoriAdi)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.UrunAdi)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.BirimdekiMiktar)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Kategorilere Gore Urunler");
            this.Property(t => t.KategoriAdi).HasColumnName("KategoriAdi");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.BirimdekiMiktar).HasColumnName("BirimdekiMiktar");
            this.Property(t => t.HedefStokDuzeyi).HasColumnName("HedefStokDuzeyi");
            this.Property(t => t.Sonlandi).HasColumnName("Sonlandi");
        }
    }
}
