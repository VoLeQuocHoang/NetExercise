using NetExercise.Array;
using NUnit.Framework;

namespace NetExercise.Test.Array
{
    public class Exercise05ArrayTest
    {
        [TestCase(new int[] {1, 3, 2, 7, 9, 4, 8, 6, 14}, "2 7 9")]
        [TestCase(new int[] {1, 3, 2, 7, 9, 4, 8, 6, 10, 14, 15, 17}, "6 10 14 15 17")]

        public void Test_SequenceNumbers_Ok(int[] arr, string result)
        {
            Assert.AreEqual(Exercise05Array.SequenceNumbers(arr), result);
        }
    }
}