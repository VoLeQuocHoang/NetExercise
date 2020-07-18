using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise04Test
    {
        [TestCase(35, "0 1 1 2 3 5 8 13 21 34")]
        [TestCase(12, "0 1 1 2 3 5 8")]
        public void Test_Fibonacci_Ok(int a, string result)
        {
            Assert.AreEqual(Exercise04.Fibonacci(a), result);
        }
    }
}