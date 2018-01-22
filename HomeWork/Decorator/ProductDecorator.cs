using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ProductDecorator : IProduct
    {
        private IProduct _product;

        public ProductDecorator(IProduct product)
        {
            _product = product;
            Price = product.Price;
        }
        public virtual int Code { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }

        public virtual void Print()
        {
            Console.Write($"Товар с артикулом {_product.Code}, именем {_product.Name} и ценой ");
        }
    }
}
