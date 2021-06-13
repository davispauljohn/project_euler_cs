using NUnit.Framework;
using project_euler.solutions;
using Shouldly;

namespace project_euler.tests
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    [TestFixture]
    public class LargestPrimeFactorTests
    {
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        public void IsPrime_ShouldReturnExpected(int subject, bool expected)
        {
            LargestPrimeFactor.IsPrime(subject).ShouldBe(expected);
        }

        [TestCase(0)]
        [TestCase(1)]
        public void GetPrimeFactors_WhenSubjectIsLessThan2_ShouldReturnEmpty(int subject)
        {
            LargestPrimeFactor.GetLargestPrimeFactor(subject).ShouldBe(0);
        }

        [Test]
        public void GetPrimeFactors_WhenSubjectIs2_ShouldReturnExpected()
        {
            LargestPrimeFactor.GetLargestPrimeFactor(2).ShouldBe(0);
        }

        [Test]
        public void GetPrimeFactors_WhenSubjectIs4_ShouldReturnExpected()
        {
            LargestPrimeFactor.GetLargestPrimeFactor(4).ShouldBe(2);
        }

        [Test]
        public void GetPrimeFactors_WhenSubjectIs15_ShouldReturnExpected()
        {
            LargestPrimeFactor.GetLargestPrimeFactor(15).ShouldBe(5);
        }

        [Test]
        public void GetPrimeFactors_WhenSubjectIs13195_ShouldReturnExpected()
        {
            LargestPrimeFactor.GetLargestPrimeFactor(13195).ShouldBe(29);
        }

        [Test]
        public void Solution()
        {
            LargestPrimeFactor.GetLargestPrimeFactor(600851475143).ShouldBe(6857);
        }
    }
}