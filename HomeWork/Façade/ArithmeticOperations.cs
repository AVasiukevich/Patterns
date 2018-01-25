using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Façade
{
    class ArithmeticOperations
    {
        public double GetSum(double number_1, double number_2)
        {
            return number_1 + number_2;
        }
        public double GetSub(double number_1, double number_2)
        {
            return number_1 - number_2;
        }
        public double GetMulti(double number_1, double number_2)
        {
            return number_1 * number_2;
        }
        public double GetDiv(double number_1, double number_2)
        {
            if (number_2 == 0)
                throw new ArgumentException("Деление на 0!");
            return number_1 / number_2;
        }
        public double GetSqrt(double number)
        {
            return Math.Sqrt(number);
        }
    }
}
