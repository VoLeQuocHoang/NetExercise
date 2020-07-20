using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise16Test
    {
        [TestCase(0, false)]
        [TestCase(25, false)]
        [TestCase(120, true)]
        [TestCase(40, false)]
        [TestCase(30, true)]
        [TestCase(210, false)]
        [TestCase(420, false)]

        public void Test_CheckNumber_Ok(int n, bool result)
        {
            Assert.AreEqual(Exercise16.CheckNumber(n), result);
        }
    }
}
