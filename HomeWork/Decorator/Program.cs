using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product() { Name = "Молоко", Code = 1234, Price = 1.3M };
            product.Print();

            var productRUB = new ProductRUB(product, 3.47M);
            productRUB.Print();
            var productUSD = new ProductUSD(product, 1.9M);
            productUSD.Print();

            Console.ReadLine();
        }
    }
}
