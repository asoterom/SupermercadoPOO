using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoPOO
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return Price* (decimal)Quantity * (decimal)Tax ;
        }
        public override string ToString()
        {
            return base.ToString() + "\n\t" + 
                $"Quantity ............ {Quantity} \n\t " +
                $"Measurement ......... {Measurement} \n\t ";
        }
    }
}
