using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using NUnit.Framework; 
using NetExercise.FractionLinq;
using NetExercise.OOP;
using NetExercise.Test.FractionLinq;

namespace NetExercise.Test.Linq
{
    public class ExerciseLinqTestAll: BaseTestClass
    {
        [TestCase]
        public void Test_Fraction_Biggest_Ok()
        {
            var lst = new Fraction(8, 2);
            Assert.AreEqual(new ExerciseLinq().Biggest(Fractions), lst);
        }
        
        [TestCase]
        public void Test_Fraction_Smallest_Ok()
        {
            var lst = new Fraction(10,33);
            Assert.AreEqual(new ExerciseLinq().Smallest(Fractions),lst) ;
        }
        
        [TestCase]
        public void Test_Fraction_Sum_Ok()
        {
            var lst = new Fraction(407047,13860);
            Assert.AreEqual(new ExerciseLinq().Sum(Fractions),lst);
        }
        
        [TestCase]
        public void Test_Fraction_Product_Ok()
        {
           var lst = new Fraction(95432704,64304361);
           Assert.AreEqual(new ExerciseLinq().Product(Fractions),lst);
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
            Assert.AreEqual(new ExerciseLinq().Sort(Fractions),lst);
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
            Assert.AreEqual(new ExerciseLinq().SortByNumerator(Fractions),lst);
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
                new Fraction(4,3),
                new Fraction(7,4),
                new Fraction(10,7),
                new Fraction(7,9),
                new Fraction(7,10),
                new Fraction(10,11),
                new Fraction(10,33),
            };
            Assert.AreEqual(new ExerciseLinq().SortByDenominator(Fractions),lst);
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
            Assert.AreEqual(new ExerciseLinq().CheckDuplicate(input),lst);
        }
        
        [TestCase]
        public void Test_Fraction_CheckDuplicate_Ok()
        {
            var lst = new List<Fraction>() 
            {
                new Fraction(4, 3),
                new Fraction(10,3),
            };
            Assert.AreEqual(new ExerciseLinq().CheckDuplicate(Fractions),lst);
        }
        
        [TestCase]
        public void Test_Fraction_CheckDuplicateValue_Ok()
        {
            var lst = new List<Fraction>() 
            {
                new Fraction(4, 3),
                new Fraction(10, 3),
            };
            Assert.AreEqual(new ExerciseLinq().CheckDuplicateValue(Fractions),lst);
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
            Assert.AreEqual(new ExerciseLinq().CheckEqualsNumerator(Fractions, x),lst);
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
            Assert.AreEqual(new ExerciseLinq().CheckGreateThanDenominator(Fractions, y),lst);
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
            Assert.AreEqual(new ExerciseLinq().MergeNumber(Fractions), lst);
        }
        //LinQ
    }
}