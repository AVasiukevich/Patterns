using Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class ProxyLettersCounter : ICounterLetters
    {
        private CounterLetters _lettetsCounter;
        private string _string = String.Empty;

        public ProxyLettersCounter(string str)
        {
            _string = str;
        }
        public void SumLetters(char letter)
        {
            if (_lettetsCounter == null)
                _lettetsCounter = new CounterLetters(_string.ToUpper());

            _lettetsCounter.SumLetters(Char.ToUpper(letter));
        }
    }
}
