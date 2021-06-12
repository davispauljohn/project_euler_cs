﻿using System;

namespace project_euler.solutions
{
    public class EvenFibonacciNumbers
    {
        /// <summary>
        /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
        /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        /// </summary>
        /// <param name="upperLimit">The inclusive upper limit</param>
        /// <returns></returns>
        public static int GetSumOfFibonacciNumbers(int upperLimit)
        {
            if (upperLimit < 2)
                throw new InvalidOperationException("Cannot form a fibonacci sequence when upper limit is less the two");

            if (upperLimit == 2)
                return 2;

            int previous = 1;
            int current = 2;
            int next = previous + current;
            int sum = 2;

            while(next <= upperLimit)
            {
                if (next % 2 == 0)
                    sum += next;

                previous = current;
                current = next;
                next = previous + current;
            }

            return sum;
        }
    }
}