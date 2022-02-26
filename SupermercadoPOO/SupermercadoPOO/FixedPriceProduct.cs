using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoPOO
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price * (decimal)(1+Tax);
        }
        public override string ToString()
        {
            return base.ToString() + "\n\t" +
                $"Value : ................ {ValueToPay():C2}";
        }
    }
}
