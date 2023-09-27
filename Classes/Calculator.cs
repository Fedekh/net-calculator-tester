using System.Numerics;

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

        public T Division<T>(T number1, T number2) where T : INumber<T>, IEquatable<T>
        {
            if (number2.Equals(default(T)))
            {
                throw new Exception("Non si puo dividere per zero");
            }
            else
            {
                return number1 / number2;
            }
        }



    }
}
