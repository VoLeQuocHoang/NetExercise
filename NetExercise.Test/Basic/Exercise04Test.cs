using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise04Test
    {
        [TestCase(35, "1 1 2 3 5 8 13 21 34")]
        [TestCase(12, "1 1 2 3 5 8")]
        [TestCase(0, "")]
        [TestCase(1, "1 1")]
        [TestCase(2, "1 1 2")]
        public void Test_Fibonacci_Ok(int n, string result)
        {
            Assert.AreEqual(Exercise04.Fibonacci(n), result);
        }
    }
}