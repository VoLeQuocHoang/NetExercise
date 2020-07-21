using NetExercise.Array;
using NUnit.Framework;

namespace NetExercise.Test.Array
{
    public class Exercise06ArrayTest
    {
        [TestCase(new int[] {1, 2, 5, 7, 10, 12}, 7, 3)]
        [TestCase(new int[] {1, 2, 5, 7, 10, 12}, 2, 1)]
        [TestCase(new int[] {1, 2, 5, 7, 10, 12}, 1, 0)]
        [TestCase(new int[] {1, 2, 5, 7, 10, 12}, 12, 5)]
        [TestCase(new int[] {1, 2, 5, 7, 10, 12}, 0, -1)]
        [TestCase(new int[] {1, 2, 5, 7, 10, 12}, 100, -1)]
        [TestCase(new int[] {1, 2, 5, 7, 10}, 100, -1)]
        [TestCase(new int[] {1, 2, 5, 7, 10}, 1, 0)]
        [TestCase(new int[] {1, 2, 5, 7, 10}, 10, 4)]

        public void Test_BinarySearch_Ok(int[] arr, int number, int result)
        {
            Assert.AreEqual(Exercise06Array.BinarySearch(arr, number),result);
        }

    }
}
