using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
        int Code { get; set; }

        string Print();
    }
}
