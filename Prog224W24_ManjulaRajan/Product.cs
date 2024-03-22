using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prog224W24_ManjulaRajan
{
    public abstract class Product
    {

        string _Name;
        double _Price;

        public string Name { get => _Name; set => _Name = value; }
        public double Price { get => _Price; set => _Price = value; }

        public abstract string GetProductType();
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price:C}";
        }
    }
}
