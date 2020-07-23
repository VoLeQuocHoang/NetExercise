using NetExercise.String;
using NUnit.Framework;

namespace NetExercise.Test.String
{
    public class Exercise02StringTest
    {
        [TestCase("my_string", "MyString")]
        [TestCase("hello_world__", "HelloWorld__")]

        public void Test_ConvertString_Ok(string s, string result)
        {
            Assert.AreEqual(Exercise02String.ConvertString(s), result);
        }
    }
}