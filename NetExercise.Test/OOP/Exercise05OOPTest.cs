using NetExercise.OOP;
using NUnit.Framework;

namespace NetExercise.Test.OOP
{
    public class Exercise05OOPTest
    {
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
    }
}