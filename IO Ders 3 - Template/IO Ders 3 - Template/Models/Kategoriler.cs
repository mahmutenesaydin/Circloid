using System;
using System.Collections.Generic;

namespace IO_Ders_3___Template.Models
{
    public partial class Kategoriler
    {
        public Kategoriler()
        {
            this.Urunlers = new List<Urunler>();
        }

        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string Tanimi { get; set; }
        public byte[] Resim { get; set; }
        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
