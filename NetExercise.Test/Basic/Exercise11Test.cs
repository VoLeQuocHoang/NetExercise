using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise11Test
    {
        [TestCase(4, 1)]
        [TestCase(6, 3)]
        [TestCase(30, 15)]
        public void Test_RotateBinary_Ok(int n, int result)
        {
            Assert.AreEqual(Exercise11.RotateBinary(n), result);
        }
    }
}