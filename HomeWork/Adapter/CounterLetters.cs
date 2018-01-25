using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CounterLetters : ICounterLetters
    {
        private string _string = String.Empty;
        public CounterLetters(string str)
        {
            _string = str;
        }
        public void SumLetters(char letter)
        {
            Console.WriteLine($"Кол-во букв = {_string.ToCharArray().Where(c => c.Equals(letter)).Count()}");
        }
    }
}
