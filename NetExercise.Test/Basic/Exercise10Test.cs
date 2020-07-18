using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Execise10Test
    {
        [TestCase(27, 3)]
        [TestCase(729, 9)]
        public void Test_CubeRoot_Ok(float a, float result)
        {
            Assert.AreEqual(Exercise10.CubeRoot(a), result);
        }
    }
}