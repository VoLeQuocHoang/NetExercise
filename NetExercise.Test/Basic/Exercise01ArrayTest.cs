using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise01ArrayTest
    {
        [TestCase(new int[] {1,2,3,6,5,9,3,4,6,5,5,2,7,5,7},"2 3 5 6 7")]

        public void Test_CountNumberShow_Ok(int[] n, string result)
        {
            Assert.AreEqual(Exercise01Array.CountNumberShow(n), result);
        }
    }
}