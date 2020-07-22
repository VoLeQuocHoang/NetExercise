using NetExercise.String;
using NUnit.Framework;

namespace NetExercise.Test.String
{
    public class Exercise04StringTest
    {
        [TestCase("abc 123 def 33 mn 3.221", 380)]

        public void Test_SumNumbers_Ok(string s, int result)
        {
            Assert.AreEqual(Exercise04String.SumNumbers(s),result);
        }
    }
}