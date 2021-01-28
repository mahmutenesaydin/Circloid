using System;
using System.Collections.Generic;

namespace IO_Ders_3___Template.Models
{
    public partial class Bolge
    {
        public Bolge()
        {
            this.Bolgelers = new List<Bolgeler>();
        }

        public int BolgeID { get; set; }
        public string BolgeTanimi { get; set; }
        public virtual ICollection<Bolgeler> Bolgelers { get; set; }
    }
}
