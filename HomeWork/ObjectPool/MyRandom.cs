using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    class MyRandom
    {
        public bool IsCreate { get; set; }
        private long num;
        public BigInteger Fact { get; set; }
        Func<long, BigInteger> Factorial = null;

        public MyRandom()
        {
            num = new Random(DateTime.Now.Millisecond).Next(100, 10000);
            Factorial = x => x == 0 ? 1 : x * Factorial(x - 1);
            Fact = Factorial(num);
        }

        public override string ToString()
        {
            return String.Format($"Factorial {num} = {Fact}");
        }
    }
}
