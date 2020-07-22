using System;
using System.Linq;
using NetExercise.Array;
using NUnit.Framework;

namespace NetExercise.Test.Array
{
    public class Exercise09ArrayTest
    {
        [TestCase(3, 5)]
        [TestCase(5, 10)]
        [TestCase(14, 20)]
        [TestCase(20, 30)]
        public void Test_RandomArray_Should_Give_N_Valid_Numbers(int n, int m)
        {
            var result = Exercise09Array.RandomArray(n, n);
            
            Assert.IsTrue(result.Distinct().Count() == n); // Đảm bảo ra n số
            Assert.IsTrue(result.All(x=>x>=1 && x <= m)); // Đảm bảo các số có giá trị từ 1~m
        }
        
        [TestCase(5, 10, 10)]
        [TestCase(14, 20, 10)]
        [TestCase(20, 30, 10)]
        public void Test_RandomArray_Should_Random_Numbers(int n, int m, int count)
        {
            var agg = Enumerable.Range(1, count)
                .Select(_ => Exercise09Array.RandomArray(n, n))
                .ToArray();

            var random = new Random().Next(n);

            //Các giá trị đầu phải ngẫu nhiên
            Assert.IsTrue(agg.Select(x=>x.First()).Distinct().Count() < count);
            
            //Các giá trị cuối phải ngẫu nhiên
            Assert.IsTrue(agg.Select(x=>x.Last()).Distinct().Count() < count);
            
            //Các giá trị tại một vị trí ngẫu nhiên phải ngẫu nhiên
            Assert.IsTrue(agg.Select(x=>x[random]).Distinct().Count() < count);
        }
    }
}