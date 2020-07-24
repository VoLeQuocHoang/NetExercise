using NetExercise.String;
using NUnit.Framework;

namespace NetExercise.Test.String
{
    public class Exercise06StringTest
    {
        [TestCase("abcccceeeeeefd", "abc4e6fd")]
        [TestCase("abbbbbbbbbbbbbc", "ab13c")]
        [TestCase("abcdsaa", "abcdsa2")]
        [TestCase("abcd", "abcd")]

        public void Test_CountCharacter_Ok(string s, string result)
        {
            Assert.AreEqual(Exercise06String.CountCharacter(s), result);
        }
    }
}