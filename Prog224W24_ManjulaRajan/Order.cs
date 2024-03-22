using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_ManjulaRajan
{
    internal class Order
    {

        List<Product> Products;
        private double totalPrice;

        public List<Product> Products1 { get => Products; set => Products = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
