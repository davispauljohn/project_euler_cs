using NUnit.Framework;
using project_euler.solutions;
using Shouldly;
using System;

namespace project_euler.tests
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    [TestFixture]
    public class EvenFibonacciNumbersTests
    {
        [Test]
        public void Run_WhenUpperLimitIsThree_ShouldReturnTwo()
        {
            EvenFibonacciNumbers.GetSumOfFibonacciNumbers(3).ShouldBe(2);
        }

        [Test]
        public void Run_WhenUpperLimitIsTen_ShouldReturnTwentyThree()
        {
            EvenFibonacciNumbers.GetSumOfFibonacciNumbers(10).ShouldBe(2 + 8);
        }

        [TestCase(0)]
        [TestCase(1)]
        public void Run_WhenUpperLimitIsLessThanTwo_ShouldThrowInvalidOperationException(int upperLimit)
        {
            Should.Throw<InvalidOperationException>(() => EvenFibonacciNumbers.GetSumOfFibonacciNumbers(upperLimit));
        }

        [Test]
        public void Run_WhenUpperLimitIsTwo_ShouldReturnTwo()
        {
            EvenFibonacciNumbers.GetSumOfFibonacciNumbers(2).ShouldBe(2);
        }

        [Test]
        public void Solution()
        {
            EvenFibonacciNumbers.GetSumOfFibonacciNumbers(4000000).ShouldBe(4613732);
        }
    }
}