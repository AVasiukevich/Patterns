using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var listUniver = new ListUniversity();
            listUniver.AddUniversity(new University(4,8,"BGU"));
            listUniver.AddUniversity(new University(5, 10, "MGU"));
            listUniver.AddUniversity(new University(7, 3, "RGU"));

            foreach (var item in listUniver)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
