using NUnit.Framework;
using project_euler.solutions;
using Shouldly;

namespace project_euler.tests
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    [TestFixture]
    public class MultiplesOfThreeAndFiveTests
    {
        [Test(Description = "Base case: multiples of three")]
        public void Run_WhenUpperLimitIsThree_ShouldReturnZero()
        {
            MultiplesOfThreeAndFive.Run(3).ShouldBe(0);
        }

        [Test(Description = "Base case: multiples of five")]
        public void Run_WhenUpperLimitIsFive_ShouldReturnThree()
        {
            MultiplesOfThreeAndFive.Run(5).ShouldBe(3);
        }

        [Test(Description = "Edge case: multiples of both three and five")]
        public void Run_WhenUpperLimitIsFifteen_ShouldReturnFortyFive()
        {
            MultiplesOfThreeAndFive.Run(15).ShouldBe(3 + 5 + 6 + 9 + 10 + 12);
        }

        [Test(Description = "Edge case: zero")]
        public void Run_WhenUpperLimitIsZero_ShouldReturnZero()
        {
            MultiplesOfThreeAndFive.Run(0).ShouldBe(0);
        }

        [Test(Description = "Edge case: negative multiples of three")]
        public void Run_WhenUpperLimitIsNegativeThree_ShouldReturn0()
        {
            MultiplesOfThreeAndFive.Run(-3).ShouldBe(0);
        }

        [Test(Description = "Edge case: negative multiples of five")]
        public void Run_WhenUpperLimitIsNegativeFive_ShouldReturnNegativeThree()
        {
            MultiplesOfThreeAndFive.Run(-5).ShouldBe(-3);
        }

        [Test(Description = "Edge case: negative multiples of three and five")]
        public void Run_WhenUpperLimitIsNegativeFifteen_ShouldReturnNegativeFortyFive()
        {
            MultiplesOfThreeAndFive.Run(-15).ShouldBe(-3 + -5 + -6 + -9 + -10 + -12);
        }

        [Test(Description = "Solution")]
        public void Run_WhenUpperLimitIsOneThousand_ShouldReturnZero()
        {
            MultiplesOfThreeAndFive.Run(1000).ShouldBe(233168);
        }
    }
}