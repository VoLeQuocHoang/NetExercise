using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise15Test
    {
        [TestCase(10, 7)]
        
        public void Test_CountNumber_Ok(int n, int result)
        {
            Assert.AreEqual(Exercise15.CountNumber(n), result);
        }
    }
}