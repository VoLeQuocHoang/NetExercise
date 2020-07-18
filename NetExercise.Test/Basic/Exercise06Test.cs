using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise06Test
    {
        [TestCase(2, 8)]
        [TestCase(3, 20)]
        [TestCase(10, 440)]
        public void Test_SumOfSequence_Ok(int a, int result)
        {
            Assert.AreEqual(Exercise06.SumOfSequence(a), result);
        }

    }
}