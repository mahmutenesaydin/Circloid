using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace IO_Ders_3___Template.Models.Mapping
{
    public class Satislar_SorgusuMap : EntityTypeConfiguration<Satislar_Sorgusu>
    {
        public Satislar_SorgusuMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SatisID, t.SirketAdi });

            // Properties
            this.Property(t => t.SatisID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MusteriID)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.SevkAdi)
                .HasMaxLength(40);

            this.Property(t => t.SevkAdresi)
                .HasMaxLength(60);

            this.Property(t => t.SevkSehri)
                .HasMaxLength(15);

            this.Property(t => t.SevkBolgesi)
                .HasMaxLength(15);

            this.Property(t => t.SevkPostaKodu)
                .HasMaxLength(10);

            this.Property(t => t.SevkUlkesi)
                .HasMaxLength(15);

            this.Property(t => t.SirketAdi)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Adres)
                .HasMaxLength(60);

            this.Property(t => t.Sehir)
                .HasMaxLength(15);

            this.Property(t => t.Bolge)
                .HasMaxLength(15);

            this.Property(t => t.PostaKodu)
                .HasMaxLength(10);

            this.Property(t => t.Ulke)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Satislar Sorgusu");
            this.Property(t => t.SatisID).HasColumnName("SatisID");
            this.Property(t => t.MusteriID).HasColumnName("MusteriID");
            this.Property(t => t.PersonelID).HasColumnName("PersonelID");
            this.Property(t => t.SatisTarihi).HasColumnName("SatisTarihi");
            this.Property(t => t.OdemeTarihi).HasColumnName("OdemeTarihi");
            this.Property(t => t.SevkTarihi).HasColumnName("SevkTarihi");
            this.Property(t => t.ShipVia).HasColumnName("ShipVia");
            this.Property(t => t.NakliyeUcreti).HasColumnName("NakliyeUcreti");
            this.Property(t => t.SevkAdi).HasColumnName("SevkAdi");
            this.Property(t => t.SevkAdresi).HasColumnName("SevkAdresi");
            this.Property(t => t.SevkSehri).HasColumnName("SevkSehri");
            this.Property(t => t.SevkBolgesi).HasColumnName("SevkBolgesi");
            this.Property(t => t.SevkPostaKodu).HasColumnName("SevkPostaKodu");
            this.Property(t => t.SevkUlkesi).HasColumnName("SevkUlkesi");
            this.Property(t => t.SirketAdi).HasColumnName("SirketAdi");
            this.Property(t => t.Adres).HasColumnName("Adres");
            this.Property(t => t.Sehir).HasColumnName("Sehir");
            this.Property(t => t.Bolge).HasColumnName("Bolge");
            this.Property(t => t.PostaKodu).HasColumnName("PostaKodu");
            this.Property(t => t.Ulke).HasColumnName("Ulke");
        }
    }
}
