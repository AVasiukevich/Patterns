using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudent student_1 = new BestStudent();
            var obj_1 = student_1.WhoIsI();
            Console.WriteLine(obj_1);

            IStudent student_2 = new BadStudent();
            var obj_2 = student_2.WhoIsI();
            Console.WriteLine(obj_2);

            Console.ReadLine();
        }
    }
}
