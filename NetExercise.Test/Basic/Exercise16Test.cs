using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise16Test
    {
        [TestCase(30, true)]

        public void Test_Check_Ok(int n, bool result)
        {
            Assert.AreEqual(Exercise16.Check(n), result);
        }
    }
}