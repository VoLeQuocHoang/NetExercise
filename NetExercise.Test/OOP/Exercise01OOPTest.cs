using NetExercise.OOP;
using NUnit.Framework;

namespace NetExercise.Test.OOP
{
    public class Exercise01OOPTest
    {
        [TestCase(8, 9, 8, 9)]
        public void Test_Fraction_Ok(int a, int b, int c, int d)
        {
            var frac1 = new Fraction(a,b);
            var frac2 = new Fraction(c,d);
            Assert.AreEqual(frac1,frac2);
        }
    }
}