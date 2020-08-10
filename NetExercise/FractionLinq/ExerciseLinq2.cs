using System;
using System.Collections.Generic;
using System.Linq;

namespace NetExercise.FractionLinq
{
    public class ExerciseLinq2
    {
        //Lấy ra 3 phần tử lớn nhất
        public static List<int> GetMaxOf3(List<int> lst)
        {
            return lst.OrderByDescending(n => n).Take(3).ToList();
        }
        
        //Lấy ra 3 giá trị lớn nhất
        public static List<int> GetMaxOf3WithValue(List<int> lst)
        {
            return lst.OrderByDescending(n => n).Distinct().Take(3).ToList();
        }

        //Lấy ra n giá trị bất kỳ
        public static List<int> TakeNRandomItem(List<int> lst, int n)
        {
            var rd = new Random();
            
            return lst.OrderBy(n => rd.Next()).Take(n).ToList();
        }
        
        //Sắp xếp giá trị theo giá trị của số hàng đơn vị
        public static List<int> SortList(List<int> lst)
        {
            return lst.OrderBy(n => n % 10).ToList();
        }

        //Tìm giá trị bị lặp nhiều lần nhất
        public static int GetNumberMostDuplicate(List<int> lst)
        {
            return lst.GroupBy(x => x).OrderByDescending(gr => gr.Count()).Select(a => a.First()).Take(1).FirstOrDefault();
        }

        //Tìm ra danh sách các giá trị không bị lặp
        public static List<int> ListNumbersDontDuplicate(List<int> lst)
        {
            return lst.GroupBy(x => x).Where(gr => gr.Count() == 1).SelectMany(a => a).ToList();
        }

        //Tìm ra danh sách các giá trị bị lặp
        public static List<int> ListNumbersDuplicate(List<int> lst)
        {
            return lst.GroupBy(x => x).Where(gr => gr.Count() > 1).Select(a => a.First()).ToList();
        }
        
        //Sắp xếp theo số lượng chữ số tăng dần
        public static List<int> SortListByNumberOfDigits(List<int> lst)
        {
            return lst.OrderBy(x => x.ToString().Length).ToList();
        }
        
        //Tính tổng của các số chẵn
        public static int SumOfEvenNumbers(List<int> lst)
        {
            return lst.Sum(x => {
                if(x % 2 == 0)
                {
                    return x;
                } 
                else
                {
                    return 0;
                }
            });
        }
        
        //Tính số chính phương lớn nhất
        public static int FindSquareNumberBiggest(List<int> lst)
        {
            return lst.Where(x => x == Math.Pow((int)Math.Sqrt(x),2)).OrderByDescending(n => n).Take(1).FirstOrDefault();
        }
        
        //Tính tổng của các số chính phương
        public static int SumOfSquareNumbers(List<int> lst)
        {
            return lst.Where(x => x == Math.Pow((int)Math.Sqrt(x),2)).Sum();
        }
        
        //Đếm số lượng số nguyên tố
        public static int CountPrimeNumbers(List<int> lst)
        {
            return lst.Where(n => {
                if (n < 2) return false;
            
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0) return false;
                }

                return true;
            }).Distinct().Count();
        }
    }
}