using System;
using System.Collections.Generic;

namespace IO_Ders_3___Template.Models
{
    public partial class Order_Subtotal
    {
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
