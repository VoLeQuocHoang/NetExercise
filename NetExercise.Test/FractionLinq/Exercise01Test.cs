using System.Collections.Generic;
using NetExercise.FractionLinq;
using NetExercise.OOP;
using NUnit.Framework;

namespace NetExercise.Test.FractionLinq
{
    public class Exercise01Test: BaseTestClass
    {
        [TestCase]
        public void Test_GetMaxOf3()
        {
            var expectedResult = new List<Fraction>()
            {
                new Fraction(8, 2),
                new Fraction(10, 3),
                new Fraction(10, 3),
            };
            Assert.AreEqual(new Exercise01().GetMaxOf3(Fractions), expectedResult);
        }
    }
}