using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new ProxyLettersCounter("Abc bcca aaa bbb ccc");
            counter.SumLetters('a');
            counter.SumLetters('c');
            Console.ReadLine();
        }
    }
}
