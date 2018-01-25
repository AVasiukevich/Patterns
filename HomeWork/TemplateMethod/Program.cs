using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new Sсhool(4,9);
            school.Study();
            school.GetAttestat();

            var univer = new University(2, 9);
            univer.Study();
            univer.GetAttestat();

            Console.ReadLine();
        }
    }
}
