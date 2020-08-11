using System.Collections.Generic;
using System.Linq;
using NetExercise.FractionLinq;
using NUnit.Framework;

namespace NetExercise.Test.FractionLinq
{
    public class ExerciseLinq2Test : BaseTestClass
    {
        [TestCase]
        public void Test_GetMaxOf3_Ok()
        {
            var lst = new List<int> {675451, 675451, 78934};
            Assert.AreEqual(ExerciseLinq2.GetMaxOf3(Lists), lst);
        }

        [TestCase]
        public void Test_GetMaxOf3WithValue_Ok()
        {
            var lst = new List<int> {675451, 78934, 7645};
            Assert.AreEqual(ExerciseLinq2.GetMaxOf3WithValue(Lists), lst);
        }

        [TestCase(8)]
        [TestCase(11)]
        [TestCase(5)]
        public void Test_TakeNRandomItem_Ok(int n)
        {
            var listRandom = ExerciseLinq2.TakeNRandomItem(Lists, n);
            Assert.AreEqual(listRandom.Count, n);
        }

        [TestCase]
        public void Test_SortList_Ok()
        {
            var slst = new List<int>
            {
                30, 10, 21, 1, 11, 675451, 675451, 22, 12, 13, 3, 3523, 2343, 4, 14, 78934, 225, 7645, 6, 16, 17, 27, 8,
                28, 29, 19, 9
            };
            Assert.AreEqual(ExerciseLinq2.SortList(Lists), slst);
        }

        [TestCase(675451)]
        public void Test_GetNumberMostDuplicate_Ok(int n)
        {
            Assert.AreEqual(ExerciseLinq2.GetNumberMostDuplicate(Lists), n);
        }

        [TestCase]
        public void Test_ListNumbersDontDuplicate_Ok()
        { 
            var lst1 = new List<int> {21,30,8,29,4,1,22,11,17,27,19,6,28,13,16,12,10,9,3,14,225,3523,7645,2343,78934 }; 
            Assert.AreEqual(ExerciseLinq2.ListNumbersDontDuplicate(Lists), lst1);
        }

        [TestCase]
        public void Test_ListNumbersDuplicate_Ok()
        {
            var lst1 = new List<int> {675451};
            Assert.AreEqual(ExerciseLinq2.ListNumbersDuplicate(Lists), lst1);
        }

        [TestCase]
        public void Test_SortListByNumberOfDigits_Ok()
        {
            var lst1 = new List<int> {8,4,1,6,9,3,21,30,29,22,11,17,27,19,28,13,16,12,10,14,225,3523,7645,2343,78934,675451,675451};
            Assert.AreEqual(ExerciseLinq2.SortListByNumberOfDigits(Lists), lst1);
        }

        [TestCase(79084)]
        public void Test_SumOfEvenNumbers_Ok(int n)
        {
            Assert.AreEqual(ExerciseLinq2.SumOfEvenNumbers(Lists), n);
        }

        [TestCase(225)]
        public void Test_FindSquareNumberBiggest_Ok(int n)
        {
            Assert.AreEqual(ExerciseLinq2.FindSquareNumberBiggest(Lists), n);
        }

        [TestCase(255)]
        public void Test_SumOfSquareNumbers_Ok(int n)
        {
            Assert.AreEqual(ExerciseLinq2.SumOfSquareNumbers(Lists), n);
        }
        
        [TestCase(6)]
        public void Test_CountPrimeNumbers_Ok(int n)
        {
            Assert.AreEqual(ExerciseLinq2.CountPrimeNumbers(Lists), n);
        }
    }
}