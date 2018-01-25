using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Façade
{
    class Calculator
    {
        static readonly ArithmeticOperations _arithmeticOperations = new ArithmeticOperations();
        static readonly Factorial _factorial = new Factorial();
        static readonly Logarithm _logarithm = new Logarithm();

        public double Sum(double number_1, double number_2)
        {
            return _arithmeticOperations.GetSum(number_1, number_2);
        }
        public double Sub(double number_1, double number_2)
        {
            return _arithmeticOperations.GetSub(number_1, number_2);
        }
        public double Multi(double number_1, double number_2)
        {
            return _arithmeticOperations.GetMulti(number_1, number_2);
        }
        public double Div(double number_1, double number_2)
        {
            return _arithmeticOperations.GetDiv(number_1, number_2);
        }
        public double Sqrt(double number)
        {
            return _arithmeticOperations.GetSqrt(number);
        }
        public BigInteger Fact(int number)
        {
            return _factorial.GetFactorial(number);
        }
        public double Log(double number)
        {
            return _logarithm.GetLogarithm(number);
        }
    }
}
