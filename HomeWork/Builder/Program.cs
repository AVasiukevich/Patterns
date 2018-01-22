using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new GlobalBlueBuilder();

            var check = builder.SetDate(DateTime.Now).SetSum(41000).SetPercentTax(18).GetCheck();

            Console.WriteLine(check.ToString());
            Console.ReadLine();
        }
    }
}
