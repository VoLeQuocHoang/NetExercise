using System;
using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise18Test
    {
        [TestCase(19, true)]
        [TestCase(190, true)]
        [TestCase(191, false)]
        [TestCase(7, true)]
        [TestCase(10, true)]
        [TestCase(13, true)]
        [TestCase(1, true)]
        [TestCase(4, false)]
        [TestCase(3, false)]

        public void Test_HappyNumber_Ok(int n, bool result)
        {
            Assert.AreEqual(Exercise18.HappyNumber(n), result);
        }
    }
}