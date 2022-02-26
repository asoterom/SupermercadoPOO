using System;

namespace SupermercadoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Product product1 = new FixedPriceProduct()
            {
                Description = "Caramelo de Limon",
                Tax = 0.18F,
                Id = 1010,
                Price = 2.5M
            };

            Product product2 = new VariablePriceProduct()
            {
                Description = "Queso Holandes",
                Id = 3030,
                Measurement = "Kilo",
                Price = 18000M,
                Quantity = 0.389F,
                Tax = 0.19F
            };
            Console.WriteLine("Products");
            Console.WriteLine("==============");
            Console.WriteLine(product1);
            Console.WriteLine(product2);

        }
    }
}
