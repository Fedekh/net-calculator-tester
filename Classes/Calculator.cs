using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester.Classes
{
    public class Calculator
    {
        public T Summ<T>(T number1, T number2) where T : INumber<T>
        {
            return number1 + number2;
        }
        public T Difference<T>(T number1, T number2) where T : INumber<T>
        {
            return number1 - number2;
        }
        public T Multiplier<T>(T number1, T number2) where T : INumber<T>
        {
            return number1 * number2;
        }
        public T Division<T>(T number1, T number2) where T : INumber<T>
        {
            return number1 / number2;
        }

    }
}
