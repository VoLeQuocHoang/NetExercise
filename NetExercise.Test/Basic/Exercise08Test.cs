using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise08Test
    {
        [TestCase(3.1415)]
        public void Test_Pi_Ok(double result)
        {
            Assert.AreEqual(Exercise08.Pi(), result,0.0001);
        }
    }
}