using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise02Test
    {
        [TestCase(236, 11)]
        [TestCase(156, 12)]
        public void Test_TongSoNguyen_Ok(int a, int result)
        {
            Assert.AreEqual(Exercise02.SumDigits(a), result);
        }
    }
}