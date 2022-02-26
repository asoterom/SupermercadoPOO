using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoPOO
{
    public class Invoice:IPay
    {
        private ICollection<Product> _products;
        public Invoice()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal ValueToPay()
        {
            decimal payroll = 0;
            foreach (Product item in _products)
            {
                payroll += item.ValueToPay();
            }

            return payroll;
        }

        public override string ToString()
        {
            string impresion = "RECEIPT";
            impresion += $"--------------------- \n\t";

            foreach (Product item in _products)
            {
                impresion += item.ToString() + "\n\t" ;
            }
            impresion += $"Total .... {ValueToPay()}";
            return impresion;
        }
    }
}
