using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise09Test
    {
        [TestCase(4, 2)]
        [TestCase(16, 4)]
        public void Test_SquareRoot_Ok(double a, double result)
        {
            Assert.AreEqual(Exercise09.SquareRoot(a), result,0.0001);
        }
    }
}