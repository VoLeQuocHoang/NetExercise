using NetExercise.OOP;
using NUnit.Framework;

namespace NetExercise.Test.OOP
{
    public class Exercise03OOPTest
    {
        [TestCase(8, 9, 16, 18)]
        
        public void Test_Fraction_Ok(int a, int b, int c, int d)
        {
            var frac1 = new Fraction(a,b);
            var frac2 = new Fraction(c,d);
            Assert.IsTrue(frac1 == frac2);
        }
    }
}