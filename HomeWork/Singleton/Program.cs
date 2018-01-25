using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var loger = Loger.GetInstance();
            Console.WriteLine(loger.Path);
            var loger2 = Loger.GetInstance();
            Console.WriteLine(loger2.Path);
            loger.WriteInFile();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
