using System;

namespace project_euler.solutions
{
    public class LargestPrimeFactor
    {
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        /// <param name="subject">The value to find prime factor of</param>
        /// <returns>The largest prime factor of the subject</returns>
        public static long GetLargestPrimeFactor(long subject)
        {
            if (subject < 2)
                return 0;

            if (subject % 2 == 0)
                return subject == 2 ? 0 : 2;

            long largestPrimeDivisor = 0;

            for (var divisor = 3; divisor <= Math.Sqrt(subject); divisor += 2)
                if (subject % divisor == 0)
                {
                    var quotient = subject / divisor;
                    if (IsPrime(quotient))
                        return quotient;
                    if (IsPrime(divisor))
                        largestPrimeDivisor = divisor;
                }

            return largestPrimeDivisor;
        }

        public static bool IsPrime(long number)
        {
            if (number < 2)
                return false;

            if (number % 2 == 0)
                return number == 2 ? true : false;

            for (int divisor = 3; divisor <= Math.Sqrt(number); divisor += 2)
                if (number % divisor == 0)
                    return false;

            return true;
        }
    }
}