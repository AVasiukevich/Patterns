using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            var listenerOne = new B();
            var unsubscriberOne = a.Subscribe(listenerOne);

            var listenerTwo = new B();
            var unsubscriberTwo = a.Subscribe(listenerTwo);

            TimerCallback tm = new TimerCallback(c => ((A)c).Value = new Random(DateTime.Now.Millisecond).Next(1, 100));
            Timer timer = new Timer(tm, a, 0, 5000);
            
            Console.ReadLine();
        }
    }
}
