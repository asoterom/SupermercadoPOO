using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoPOO
{
    public class ComposedProduct : Product
    {

        public float Discount { get; set; }
        public ICollection<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal precio = 0;
            foreach (Product product in Products)
            {
                precio += product.ValueToPay();
            }
            Price = precio * (decimal)(1-Discount);
            return Price;
        }

        public override string ToString()
        {
            string names = "";
            foreach (Product item in Products)
            {
                names += item.Description + ",";
            }
            names = names.Substring(0, names.Length - 1);

            return $"Product ......... {Description} \n\t" +
                $"Products .......... {names} \n\t" +
                $"Discount .......... {Discount:P2} \n\t" +
                $"Value ............. {ValueToPay():C2}";
        }
    }
}
