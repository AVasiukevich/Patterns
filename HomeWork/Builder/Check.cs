using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Check
    {
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public decimal PercentTax { get; set; }

        public override string ToString()
        {
            return String.Format($"Tax Free Check: Date {Date}, Sum {Sum}, Percent {PercentTax}%");
        }
    }
}
