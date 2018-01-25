using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Product : IProduct
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string Print()
        {
            return String.Format($"Товар с артикулом {Code}, именем {Name} и ценой {Price}");
        }
    }
}
