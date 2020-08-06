using NetExercise.OOP;
using NUnit.Framework;

namespace NetExercise.Test.OOP
{
    public class Exercise05OOPTest
    {
        [TestCase(2, 5, 5, 2)]
        [TestCase(30, 50, 10, 6)]
        public void Test_Fraction_Reverse_Ok(int a, int b, int c, int d)
        {
            var frac1 = new Fraction(a,b);
            var frac2 = new Fraction(c,d);
            Assert.IsTrue(!frac1 == frac2);
        }
        
        [TestCase(8, 9,5, 6)]
        [TestCase(156, 200,113, 367)]
        [TestCase(130, 260, 55, 110)]
        public void Test_LargerOrEqual_Ok(int a, int b, int c, int d)
        {
            var fra1 = new Fraction(a,b);
            var fra2 = new Fraction(c,d);
            Assert.IsTrue(fra1 >= fra2);
        }
        
        [TestCase(5, 6, 8, 9)]
        [TestCase(113, 367, 156, 200)]
        [TestCase(130, 260, 55, 110)]
        public void Test_LessOrEqual_Ok(int a, int b, int c, int d)
        {
            var fra1 = new Fraction(a,b);
            var fra2 = new Fraction(c,d);
            Assert.IsTrue(fra1 <= fra2);
        }
        
        [TestCase(8, 9,5, 6)]
        [TestCase(156, 200,113, 367)]
        public void Test_Larger_Ok(int a, int b, int c, int d)
        {
            var fra1 = new Fraction(a,b);
            var fra2 = new Fraction(c,d);
            Assert.IsTrue(fra1 > fra2);
        }
        
        [TestCase(5, 6, 8, 9)]
        [TestCase(113, 367, 156, 200)]
        public void Test_Less_Ok(int a, int b, int c, int d)
        {
            var fra1 = new Fraction(a,b);
            var fra2 = new Fraction(c,d);
            Assert.IsTrue(fra1 < fra2);
        }
        
        [TestCase(10, 9, 6, 25, 304, 225)]
        [TestCase(10, 9, 6, 25, 608, 450)]
        public void Test_Fraction_Plus_Ok(int a, int b, int c, int d, int e, int f)
        {
            var frac1 = new Fraction(a, b);
            var frac2 = new Fraction(c, d);
            Assert.IsTrue(frac1 + frac2 == new Fraction(e,f));
        }
        
        [TestCase(10, 9, 6, 25, 196, 225)]
        [TestCase(10, 9, 6, 25, 588, 675)]
        public void Test_Fraction_Minus_Ok(int a, int b, int c, int d, int e, int f)
        {
            var frac1 = new Fraction(a, b);
            var frac2 = new Fraction(c, d);
            Assert.IsTrue(frac1 - frac2 == new Fraction(e,f));
        }
        
        [TestCase(10, 9, 6, 25, 125, 27)]
        [TestCase(10, 9, 6, 25, 500, 108)]
        public void Test_Fraction_Divide_Ok(int a, int b, int c, int d, int e, int f)
        {
            var frac1 = new Fraction(a, b);
            var frac2 = new Fraction(c, d);
            Assert.IsTrue(frac1 / frac2 == new Fraction(e,f));
        }
        
        [TestCase(10, 9, 6, 25, 4, 15)]
        [TestCase(10, 9, 6, 25, 36, 135)]
        public void Test_Fraction_Multiply_Ok(int a, int b, int c, int d, int e, int f)
        {
            var frac1 = new Fraction(a, b);
            var frac2 = new Fraction(c, d);
            Assert.IsTrue(frac1 * frac2 == new Fraction(e,f));
        }

        [TestCase(9, 9, 1)]
        [TestCase(11, 22, 2)]
        public void Test_Fraction_ConvertToFraction_Ok(int a, int b, int c)
        {
            var frac1 = new Fraction(a);
            var frac2 = new Fraction(b,c);
            Assert.IsTrue(frac1 == frac2);
        }

        [TestCase(5, 2, 0.2, 2.7)]
        [TestCase(9, 4, 0.25, 2.5)]
        public void Test_Fraction_ConvertToValue_Ok(int a, int b, double c, double d)
        {
            var frac1 = new  Fraction(a,b);
            Assert.IsTrue((double)frac1 + c == d);
        }
        
          
        [TestCase(1, 2, 2, 5, 2)]
        [TestCase(3, 7, 9, 66, 7)]
        public void Test_Fraction_PlusBetweenFractionAndInteger_Ok(int a, int b, int c, int d, int e)
        {
            var frac1 = new Fraction(a, b);
            var frac2 = new Fraction(d, e);
            Assert.IsTrue(frac1 + c == frac2);
        }
        
        [TestCase(8, 3, 2, 2, 3)]
        [TestCase(8, 5, 1, 3, 5)]
        public void Test_Fraction_MinusBetweenFractionAndInteger_Ok(int a, int b, int c, int d, int e)
        {
            var frac1 = new Fraction(a, b);
            var frac2 = new Fraction(d, e);
            Assert.IsTrue(frac1 - c == frac2);
        }
        
        [TestCase(9, 5, 2, 18, 20)]
        [TestCase(8, 5, 6, 12, 45)]
        public void Test_Fraction_DivideBetweenFractionAndInteger_Ok(int a, int b, int c, int d, int e)
        {
            var frac1 = new Fraction(a, b);
            var frac2 = new Fraction(d, e);
            Assert.IsTrue(frac1 / c == frac2);
        }
        
        [TestCase(5, 6, 3, 10, 4)]
        [TestCase(8, 15, 5, 40, 15)]
        public void Test_Fraction_MultiplyBetweenFractionAndInteger_Ok(int a, int b, int c, int d, int e)
        {
            var frac1 = new Fraction(a, b);
            var frac2 = new Fraction(d, e);
            Assert.IsTrue(frac1 * c == frac2);
        }
    }
}