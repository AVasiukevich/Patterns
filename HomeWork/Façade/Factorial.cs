using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Façade
{
    class Factorial
    {
        Func<long, BigInteger> _factorial = null;

        public BigInteger GetFactorial(int number)
        {
            _factorial = x => x == 0 ? 1 : x * _factorial(x - 1);
            return _factorial(number);
        }

    }
}
