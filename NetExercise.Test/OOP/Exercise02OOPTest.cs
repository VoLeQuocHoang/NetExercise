using NetExercise.OOP;
using NUnit.Framework;

namespace NetExercise.Test.OOP
{
    public class Exercise02OOPTest
    {
        [TestCase(8, 9, 8, 9)]
        [TestCase(5, 13, 15, 39)]
        public void Test_Fraction_Equals_Ok(int a, int b, int c, int d)
        {
            var frac1 = new Fraction(a,b);
            var frac2 = new Fraction(c,d);
            Assert.AreEqual(frac1,frac2);
        }
        
        [TestCase(8, 9, 16, 18)]
        [TestCase(11, 17, 11, 17)]
        public void Test_Fraction_Compare_Ok(int a, int b, int c, int d)
        {
            var frac1 = new Fraction(a,b);
            var frac2 = new Fraction(c,d);
            Assert.IsTrue(frac1 == frac2);
        }
        
        [TestCase(8, 9, 15, 18)]
        [TestCase(5, 7, 5, 8)]
        public void Test_Fraction_Different_Ok(int a, int b, int c, int d)
        {
            var frac1 = new Fraction(a,b);
            var frac2 = new Fraction(c,d);
            Assert.IsTrue(frac1 != frac2);
        }
        
        [TestCase(8, 9, "8/9")]
        [TestCase(14, 18, "14/18")]
        public void Test_Fraction_String_Ok(int a, int b, string s)
        {
            var frac1 = new Fraction(a,b);
            Assert.AreEqual(frac1.ToString(),s);
        }
    }
}