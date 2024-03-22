using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog224W24_ManjulaRajan
{
    public  class Food :Product
    {
        DateTime ExpirationDate;

        public DateTime ExpirationDate1 { get => ExpirationDate; set => ExpirationDate = value; }

        public override string GetProductType()
        {
            return "Food";
        }
    }

}
