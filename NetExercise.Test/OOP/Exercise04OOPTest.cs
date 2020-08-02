using System;
using NetExercise.OOP;
using NUnit.Framework;

namespace NetExercise.Test.OOP
{
    public class Exercise04OOPTest
    {
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
    }
}