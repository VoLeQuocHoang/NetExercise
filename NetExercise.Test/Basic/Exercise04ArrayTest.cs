using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise04ArrayTest
    {
        [TestCase(new int[] {1, 2, 5, 7, 10, 12}, 14)]
        [TestCase(new int[] {1, 3, 2, 7, 9, 14}, 12)]

        public void Test_SumPrime_Ok(int[] n, int result)
        {
            Assert.AreEqual(Exercise04Array.SumPrime(n), result);
        }
    }
}