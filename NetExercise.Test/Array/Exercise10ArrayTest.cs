using NetExercise.Array;
using NUnit.Framework;

namespace NetExercise.Test.Array
{
    public class Exercise10ArrayTest
    {
        [TestCase(new int[] {1, 2, 4, 7, 10, 16}, 21)]
        [TestCase(new int[] {1, 2, 4, 7, 9, 16}, 30)]
        [TestCase(new int[] {1, 2, 9, 7, 25, 10}, 35)]
        public void Test_SumSquareNumber_Ok(int[] arr, int result)
        {
            Assert.AreEqual(Exercise10Array.SumSquareNumber(arr), result);
        }
    }
}