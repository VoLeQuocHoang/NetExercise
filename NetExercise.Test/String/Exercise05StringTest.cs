using NetExercise.String;
using NUnit.Framework;

namespace NetExercise.Test.String
{
    public class Exercise05StringTest
    {
        [TestCase("abcdcba", true)]
        [TestCase("abbbbbbbbbbbbbc", false)]
        [TestCase("abcccceeeeeefd", false)]

        public void Test_SymmetricalNumbers_Ok(string s, bool result)
        {
            Assert.AreEqual(Exercise05String.SymmetricalNumbers(s), result);
        }
    }
}