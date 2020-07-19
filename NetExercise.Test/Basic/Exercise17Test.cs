using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise17Test
    {
        [TestCase(20, 101)]

        public void Test_FindNumber_Ok(int n, int result)
        {
            Assert.AreEqual(Exercise17.FindNumber(n), result);
        }
    }
}