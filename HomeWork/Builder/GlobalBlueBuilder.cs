using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class GlobalBlueBuilder : IBuilder
    {
        private Check check = new Check();

        public Check GetCheck()
        {
            return check;
        }

        public IBuilder SetPercentTax(decimal percent)
        {
            check.PercentTax = percent;
            return this;
        }

        public IBuilder SetDate(DateTime date)
        {
            check.Date = date;
            return this;
        }

        public IBuilder SetSum(decimal sum)
        {
            check.Sum = sum;
            return this;
        }
    }
}
