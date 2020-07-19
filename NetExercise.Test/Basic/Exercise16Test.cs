using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise16Test
    {
        [TestCase(4, true)]
        [TestCase(25, true)]
        [TestCase(120, true)]
        [TestCase(40, true)]
        [TestCase(30, true)]
        [TestCase(210, false)]
        [TestCase(440, false)]

        public void Test_Check_Ok(int n, bool result)
        {
            Assert.AreEqual(Exercise16.Check(n), result);
        }
    }
}
