using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise03Test
    {
        [TestCase(600, "2 * 2 * 2 * 3 * 5 * 5")]
        public void Test_MultiplicationPrimes_Ok(int a, string result)
        {
            Assert.AreEqual(Exercise03.MultiplicationPrimes(a), result);
        }

    }
}