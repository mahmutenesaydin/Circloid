using System;
using System.Collections.Generic;

namespace IO_Ders_3___Template.Models
{
    public partial class Satislar
    {
        public int SatisID { get; set; }
        public string MusteriID { get; set; }
        public Nullable<int> PersonelID { get; set; }
        public Nullable<System.DateTime> SatisTarihi { get; set; }
        public Nullable<System.DateTime> OdemeTarihi { get; set; }
        public Nullable<System.DateTime> SevkTarihi { get; set; }
        public Nullable<int> ShipVia { get; set; }
        public Nullable<decimal> NakliyeUcreti { get; set; }
        public string SevkAdi { get; set; }
        public string SevkAdresi { get; set; }
        public string SevkSehri { get; set; }
        public string SevkBolgesi { get; set; }
        public string SevkPostaKodu { get; set; }
        public string SevkUlkesi { get; set; }
        public virtual Musteriler Musteriler { get; set; }
        public virtual Nakliyeciler Nakliyeciler { get; set; }
        public virtual Personeller Personeller { get; set; }
    }
}
