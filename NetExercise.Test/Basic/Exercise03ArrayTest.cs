using System;
using NetExercise.Basic;
using NUnit.Framework;

namespace NetExercise.Test.Basic
{
    public class Exercise03ArrayTest
    {
        [TestCase(new int[] {1, 2, 5, 7, 10, 12}, 11)]
        [TestCase(new int[] {1, 3, 2, 7, 9, 14}, -4)]

        public void Test_DifferenceArray_Ok(int[] n, int result)
        {
            Assert.AreEqual(Exercise03Array.DifferenceArray(n), result);
        }
    }
}