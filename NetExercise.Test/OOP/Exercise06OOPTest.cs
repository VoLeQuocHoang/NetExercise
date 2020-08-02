using NetExercise.OOP;
using NUnit.Framework;

namespace NetExercise.Test.OOP
{
    public class Exercise05OOPTest
    {
        [TestCase(2, 5, 5, 2)]
        [TestCase(30, 50, 5, 3)]
        public void Test_Fraction_Reverse_Ok(int a, int b, int c, int d)
        {
            var frac1 = new Fraction(a,b);
            var frac2 = new Fraction(c,d);
            Assert.IsTrue(!frac1 == frac2);
        }
    }
}