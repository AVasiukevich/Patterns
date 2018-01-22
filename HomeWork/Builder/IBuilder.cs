using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IBuilder
    {
        IBuilder SetSum(decimal sum);
        IBuilder SetDate(DateTime date);
        IBuilder SetPercentTax(decimal percent);
        Check GetCheck();
    }
}
