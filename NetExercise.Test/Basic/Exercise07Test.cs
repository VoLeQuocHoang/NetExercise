using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise07Test
    {
        [TestCase(5, 120)]
        [TestCase(10, 3628800)]
        public void Test_Factorial_Ok(int a, int result)
        {
            Assert.AreEqual(Exercise07.Factorial(a), result);
        }
    }
}