using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise09Test
    {
        [TestCase(4, 2)]
        [TestCase(16, 4)]
        public void Test_SquareRoot_Ok(float a, float result)
        {
            Assert.AreEqual(Exercise09.SquareRoot(a), result);
        }
    }
}