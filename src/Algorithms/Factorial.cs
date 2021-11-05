using System;

namespace Algorithms.Calculations
{
    public class Factorial
    {
        public static int Calculate(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(number)} can't be negative.'");
            }

            if (number > 10)
            {
                throw new NotImplementedException($"{nameof(number)} can't be larger than 10.'");
            }

            if (number == 0)
            {
                return 1;
            }

            return number * Calculate(number - 1);
        }
    }
}
