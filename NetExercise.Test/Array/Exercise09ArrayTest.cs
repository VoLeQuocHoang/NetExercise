using NetExercise.Array;
using NUnit.Framework;

namespace NetExercise.Test.Array
{
    public class Exercise09ArrayTest
    {
        [TestCase(1, "1")]
        public void Test_RandomArray_Ok(int n, string result)
        {
            Assert.AreEqual(Exercise09Array.RandomArray(n),result);
        }
    }
}