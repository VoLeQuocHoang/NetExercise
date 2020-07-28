using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise16Test
    {
        [TestCase(0, true)]
        [TestCase(25, true)]
        [TestCase(120, true)]
        [TestCase(40, true)]
        [TestCase(800, true)]
        [TestCase(840, false)]
        [TestCase(10, true)]
        [TestCase(15, true)]
        [TestCase(2, true)]
        [TestCase(6, true)]
        [TestCase(20, true)]
        [TestCase(22, false)]
        [TestCase(35, false)]
        [TestCase(30, true)]
        [TestCase(210, false)]
        [TestCase(420, false)]

        public void Test_CheckNumber_Ok(int n, bool result)
        {
            Assert.AreEqual(Exercise16.CheckNumber(n), result);
        }
    }
}
