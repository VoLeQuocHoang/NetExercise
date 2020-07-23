using NetExercise.Arrays;
using NUnit.Framework;

namespace NetExercise.Test.Arrays
{
    public class ExerciseArray01Test
    {
        [TestCase(new int[] {1,2,3,6,5,9,3,4,6,5,5,2,7,5,7},"2 3 5 6 7")]
        [TestCase(new int[] {1,1, 1, 1,1, 1, 3, 3, 3},"1 3")]
        [TestCase(new int[] {0, 0, 0, 0},"0")]

        public void Test_CountNumberShow_Ok(int[] n, string result)
        {
            Assert.AreEqual(ExerciseArray01.CountNumberShow(n), result);
        }
    }
}