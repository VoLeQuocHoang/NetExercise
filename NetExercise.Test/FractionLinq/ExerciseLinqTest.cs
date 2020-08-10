using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework; 
using NetExercise.FractionLinq;
using NetExercise.Test.FractionLinq;

namespace NetExercise.Test.Linq
{
    public class ExerciseLinqTestAll: BaseTestClass
    {
        [TestCase]
        public void Test_Fraction_Biggest_Ok()
        {
            var lst = new Fraction(8, 2);
            Assert.AreEqual(Fraction.Biggest(Fraction.Clone(Fractions)), lst);
        }
        
        [TestCase]
        public void Test_Fraction_Smallest_Ok()
        {
            var lst = new Fraction(10,33);
            Assert.AreEqual(Fraction.Smallest(Fraction.Clone(Fractions)),lst) ;
        }
        
        [TestCase]
        public void Test_Fraction_Sum_Ok()
        {
            var lst = new Fraction(388567,13860);
            Assert.AreEqual(Fraction.Sum(Fraction.Clone(Fractions)),lst);
        }
        
        [TestCase]
        public void Test_Fraction_Product_Ok()
        {
           var lst = new Fraction(1097600000,21434787);
           Assert.AreEqual(Fraction.Product(Fraction.Clone(Fractions)),lst);
        }
        
        [TestCase]
        public void Test_Fraction_Sort_Ok()
        {
            var lst = new List<Fraction>()
            {
                new Fraction(10, 33),
                new Fraction(1, 3),
                new Fraction(1, 2),
                new Fraction(2, 3),
                new Fraction(7, 10),
                new Fraction(7, 9),
                new Fraction(10, 11),
                new Fraction(4, 3),
                new Fraction(10, 7),
                new Fraction(5, 3),
                new Fraction(7, 4),
                new Fraction(6, 3),
                new Fraction(7, 3),
                new Fraction(8, 3),
                new Fraction(10, 3),
                new Fraction(10, 3),
                new Fraction(8, 2),
            };
            Assert.AreEqual(Fraction.Sort(Fraction.Clone(Fractions)),lst);
        }
        
        [TestCase]
        public void Test_Fraction_SortByNumerator_Ok()
        {
            var lst = new List<Fraction>() 
            {
                new Fraction(1,2),
                new Fraction(1,3),
                new Fraction(2,3),
                new Fraction(4,3),
                new Fraction(5,3),
                new Fraction(6,3),
                new Fraction(7,3),
                new Fraction(7,4),
                new Fraction(7,9),
                new Fraction(7,10),
                new Fraction(8,2),
                new Fraction(8,3),
                new Fraction(10,3),
                new Fraction(10,3),
                new Fraction(10,7),
                new Fraction(10,11),
                new Fraction(10,33),
            };
            Assert.AreEqual(Fraction.SortByNumerator(Fraction.Clone(Fractions)),lst);
        }
        
        [TestCase]
        public void Test_Fraction_SortByDenominator_Ok()
        {
            var lst = new List<Fraction>() 
            {
                new Fraction(1,2),
                new Fraction(8,2),
                new Fraction(1,3),
                new Fraction(2,3),
                new Fraction(5,3),
                new Fraction(6,3),
                new Fraction(4,3),
                new Fraction(7,3),
                new Fraction(8,3),
                new Fraction(10,3),
                new Fraction(10,3),
                new Fraction(7,4),
                new Fraction(10,7),
                new Fraction(7,9),
                new Fraction(7,10),
                new Fraction(10,11),
                new Fraction(10,33),
            };
            Assert.AreEqual(Fraction.SortByDenominator(Fraction.Clone(Fractions)),lst);
        }
        
        [TestCase]
        public void Test_Fraction_CheckDuplicate_Should_Not_Also_Return_Duplication()
        {
            var input = new List<Fraction>() 
            {
                new Fraction(10,3),
                new Fraction(10,3),
                new Fraction(10,3),
                new Fraction(10,3),
            };
            var lst = new List<Fraction>() 
            {
                new Fraction(10,3),
            };
            Assert.AreEqual(Fraction.CheckDuplicate(input),lst);
        }
        
        [TestCase]
        public void Test_Fraction_CheckDuplicate_Ok()
        {
            var lst = new List<Fraction>() 
            {
                new Fraction(10,3),
            };
            Assert.AreEqual(Fraction.CheckDuplicate(Fraction.Clone(Fractions)),lst);
        }
        
        [TestCase]
        public void Test_Fraction_CheckDuplicateValue_Ok()
        {
            var lst = new List<Fraction>() 
            {
                new Fraction(10, 3),
                new Fraction(10, 3),
            };
            Assert.AreEqual(Fraction.CheckDuplicateValue(Fraction.Clone(Fractions)),lst);
        }
        
        [TestCase(7)]
        public void Test_Fraction_CheckEqualsNumerator_Ok(int x)
        {
            var lst = new List<Fraction>() 
            {
                new Fraction(7, 3),
                new Fraction(7, 4),
                new Fraction(7, 9),
                new Fraction(7, 10),
            };
            Assert.AreEqual(Fraction.CheckEqualsNumerator(Fraction.Clone(Fractions), x),lst);
        }
        
        [TestCase(4)]
        public void Test_Fraction_CheckGreateThanDenominator_Ok(int y)
        {
            var lst = new List<Fraction>() {
                new Fraction(7,9),
                new Fraction(7,10),
                new Fraction(10,7),
                new Fraction(10,11),
                new Fraction(10,33),
            };
            Assert.AreEqual(Fraction.CheckGreateThanDenominator(Fraction.Clone(Fractions), y),lst);
        }
        
        [TestCase]
        public void Test_Fraction_MergeNumber_Ok()
        {
            var lst = new List<Fraction>() {
                new Fraction(1, 2),
                new Fraction(1, 3),
                new Fraction(2, 3),
                new Fraction(5, 3),
                new Fraction(6, 3),
                new Fraction(4, 3),
                new Fraction(7, 3),
                new Fraction(7, 4),
                new Fraction(7, 9),
                new Fraction(7, 10),
                new Fraction(8, 2),
                new Fraction(8, 3),
                new Fraction(10, 3),
                new Fraction(10, 7),
                new Fraction(10, 11),
                new Fraction(10, 33),
            };
            Assert.AreEqual(Fraction.MergeNumber(Fraction.Clone(Fractions)), lst);
        }
        //LinQ
    }
}