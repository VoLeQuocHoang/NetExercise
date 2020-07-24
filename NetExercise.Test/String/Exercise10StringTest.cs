using System;
using NetExercise.String;
using NUnit.Framework;

namespace NetExercise.Test.String
{
    public class Exercise10StringTest
    {
        [TestCase("Truong Van Chan Phong", "Truong Van Chan", "Phong")]
        [TestCase("Truong Van Voon", "Truong Van", "Voon")]
        [TestCase("Họ Và Tên", "Họ Và", "Tên")]

        public void Test_SplitName_Ok(string s, string result, string result2)
        {
            Assert.AreEqual(Exercise10String.SplitName(s), Tuple.Create(result, result2));
        }
    }
}