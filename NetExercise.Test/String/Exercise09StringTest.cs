using NetExercise.String;
using NUnit.Framework;

namespace NetExercise.Test.String
{
    public class Exercise09StringTest
    {
        [TestCase("9501101530003", true)]
        [TestCase("7501054530107", true)]
        [TestCase("0075678164125", true)]

        public void Test_CheckBarcode_Ok(string s, bool result)
        {
            Assert.AreEqual(Exercise09String.CheckBarcode(s), result);
        }
    }
}