using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new CollectionNumber();
            collection.Subscribe(new Listener());
            collection.Add(5);
            collection.Add(1);
            collection.Add(3);
            collection.Subscribe(new Listener());
            collection.Add(0);
            collection.Delete(1);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
