using System;
using System.Collections.Generic;

namespace IO_Ders_3___Template.Models
{
    public partial class Summary_of_Sales_by_Quarter
    {
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
