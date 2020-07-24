using NetExercise.String;
using NUnit.Framework;

namespace NetExercise.Test.String
{
    public class Exercise08StringTest
    {
        [TestCase("abbbbbbccccd eeffffddbc", "abcd efdbc")]
        [TestCase("abbbbbbccccd hnkdd", "abcd hnkd")]
        [TestCase("aaaaaaaa", "a")]
        [TestCase("aaaaaaaaddddddd", "ad")]
        public void Test_ConvertString_Ok(string s, string result)
        {
            Assert.AreEqual(Exercise08String.ConvertString(s), result);
        }
    }
}