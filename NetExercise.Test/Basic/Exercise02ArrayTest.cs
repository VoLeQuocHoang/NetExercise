using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise02ArrayTest
    {
        [TestCase(new int[] {1, 2, 3, 6, 5, 9, 3, 4, 6, 5, 5, 2, 7, 7, 5, 7}, 22)]

        public void Test_SumArray_Ok(int[] n, int result)
        {
            Assert.AreEqual(Exercise02Array.SumArray(n), result);
        }
    }
}