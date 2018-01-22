using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Façade
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine(calculator.Sum(10, 20));
            Console.WriteLine(calculator.Sub(100, 20));
            Console.WriteLine(calculator.Multi(5, 10));
            Console.WriteLine(calculator.Div(10, 2));
            Console.WriteLine(calculator.Sqrt(100));
            Console.WriteLine(calculator.Fact(11));
            Console.WriteLine(calculator.Log(144));

            Console.ReadLine();
        }
    }
}
