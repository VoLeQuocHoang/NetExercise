using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise05Test
    {
        [TestCase("153 370 371 407 1634 8208 9474 54748 92727 93084")]
        public void Test_TimSo_Ok(string result)
        {
            Assert.AreEqual(Exercise05.FindNumber(), result);
        }
    }
}