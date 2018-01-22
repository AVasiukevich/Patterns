using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initialize pool...");
            var pool = new MyRandomPool(4,1);

            var fact1 = pool.GetFactorial();
            Console.WriteLine(fact1.ToString());
            var fact2 = pool.GetFactorial();
            Console.WriteLine(fact2.ToString());
            var fact3 = pool.GetFactorial();
            Console.WriteLine(fact3.ToString());
            var fact4 = pool.GetFactorial();
            Console.WriteLine(fact4.ToString());
            var fact5 = pool.GetFactorial();
            pool.ReleaseConnection(fact1);
            pool.ReleaseConnection(fact2);
            pool.ReleaseConnection(fact3);
            pool.ReleaseConnection(fact4);
            Console.ReadLine();
        }
    }
}
