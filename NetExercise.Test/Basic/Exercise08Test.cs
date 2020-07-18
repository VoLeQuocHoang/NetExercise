using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise08Test
    {
        [TestCase(3.1415f)]
        public void Test_Pi_Ok(float result)
        {
            Assert.AreEqual(Exercise08.Pi(), result);
        }
    }
}