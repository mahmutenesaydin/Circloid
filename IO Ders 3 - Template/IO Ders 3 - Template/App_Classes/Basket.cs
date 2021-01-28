using IO_Ders_3___Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Ders_3___Template.App_Classes
{
    public class Basket
    {
        private List<Product> product = new List<Product>();

        public List<Product> Product
        {
            get { return product; }
            set { product = value; }
        }

    }
}