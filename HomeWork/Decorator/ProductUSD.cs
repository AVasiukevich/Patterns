using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ProductUSD : ProductDecorator
    {
        private decimal _rate;
        public ProductUSD(IProduct product, decimal rate) : base(product)
        {
            _rate = rate;
        }
        public override string Print()
        {
            return base.Print() + String.Format($"{base.Price / _rate} USD");
        }
    }
}
