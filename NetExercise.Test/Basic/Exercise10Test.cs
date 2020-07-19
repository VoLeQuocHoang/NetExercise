using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Execise10Test
    {
        [TestCase(27, 3)]
        [TestCase(729, 9)]
        [TestCase(52.5, 3.7444)]
        public void Test_CubeRoot_Ok(double a, double result)
        {
            Assert.AreEqual(Exercise10.CubeRoot(a), result, 0.0001);
        }
    }
}