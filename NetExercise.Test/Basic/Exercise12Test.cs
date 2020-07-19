using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise12Test
    {
        [TestCase(26762, true)]
        [TestCase(3443, true)]
        [TestCase(12, false)]
        public void Test_SymmetricNumber_Ok(int n, bool result)
        {
            Assert.AreEqual(Exercise12.SymmetricNumber(n), result);
        }
    }
}