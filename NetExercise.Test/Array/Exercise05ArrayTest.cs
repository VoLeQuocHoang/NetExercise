using NetExercise.Array;
using NUnit.Framework;

namespace NetExercise.Test.Array
{
    public class Exercise05ArrayTest
    {
        [TestCase(new int[] {1, 3, 2, 7, 9, 4, 8, 6, 14}, "1 2 3 4")]
        [TestCase(new int[] {1, 3, 2, 7, 9, 4, 8, 6, 10, 14}, "6 7 8 9 10")]

        public void Test_SequenceNumbers_Ok(int[] arr, string result)
        {
            Assert.AreEqual(Exercise05Array.SequenceNumbers(arr), result);
        }
    }
}