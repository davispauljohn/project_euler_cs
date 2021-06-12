using System;

namespace project_euler.solutions
{
    public class MultiplesOfThreeAndFive
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        /// <param name="upperLimit">The exclusive upper limit</param>
        /// <returns>The sum of the multiples of three and five between 0 and a user specified limit</returns>
        public static int GetMultiplesOfThreeAndFive(int upperLimit)
        {
            int count = 1;
            int sum = 0;
            bool isNegated = false;

            if(upperLimit < 0)
            {
                upperLimit = -upperLimit;
                isNegated = true;
            }

            while (count < upperLimit)
            {
                if (count % 3 == 0 || count % 5 == 0)
                    sum += count;

                count++;
            }

            return isNegated ? -sum : sum;
        }
    }
}
