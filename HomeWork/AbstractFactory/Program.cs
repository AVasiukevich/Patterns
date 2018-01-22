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
            var factory = new FactoryStudent();
            var student_1 = factory.CreateStudent(5, "Belarus");
            Console.WriteLine(student_1.WhoAmI());
            var student_2 = factory.CreateStudent(5, "Iran");
            Console.WriteLine(student_2.WhoAmI());

            Console.ReadLine();
        }
    }
}
