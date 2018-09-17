using System;

namespace Extensions
{
    static class Util
    {
        public static int ConvertToBase(this int i, int baseToConverTo)
        {
            if (baseToConverTo < 2 || baseToConverTo > 10)
            {
                throw new ArgumentException("Value cannot be converted to base " + baseToConverTo.ToString());
            }

            int result = 0;
            int iterations = 0;
            do
            {
                int nextDigit = i % baseToConverTo;
                i /= baseToConverTo;
                result += nextDigit * (int)Math.Pow(10, iterations);
                iterations++;
            }
            while (i != 0);
            return result;
        }
    }
}