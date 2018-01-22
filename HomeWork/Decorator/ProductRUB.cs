using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ProductRUB : ProductDecorator
    {
        private decimal _rate;
        public ProductRUB(IProduct product, decimal rate) : base(product)
        {
            _rate = rate;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{base.Price / _rate * 100} RUB");
        }
    }
}
