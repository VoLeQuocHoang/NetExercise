using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using NetExercise.OOP;

namespace NetExercise.FractionLinq
{
    public class ExerciseLinq
    {
        //Tìm giá trị Fraction lớn nhất
        public Fraction Biggest(List<Fraction> lst)
        {
            return lst.OrderByDescending(s => (double) s).First();
        }    
        
        //Tìm giá trị Fraction nhỏ nhất
        public Fraction Smallest(List<Fraction> lst)
        {
            return lst.OrderByDescending(s => (double) s).Last();
        }

        //Tìm giá trị tổng của tất cả các giá trị
        public Fraction Sum(List<Fraction> lst)
        {
            return lst.Aggregate((s1, s2) => s1 + s2);
        }
        
        //Tìm giá trị tích của tất cả các giá trị
        public Fraction Product(List<Fraction> lst)
        {
            return lst.Aggregate((s1, s2) => s1 * s2);
        }
        
        //Sắp xếp các giá trị theo giá trị thực tăng dần
        public List<Fraction> Sort(List<Fraction> lst)
        {
            return lst.OrderBy(s => (double) s).ToList();
        }

        //Sắp xếp các giá trị theo tử số tăng dần
        public List<Fraction> SortByNumerator(List<Fraction> lst)
        {
            return lst.OrderBy(s => s.A).ToList();
        }
        
        //Sắp xếp các giá trị theo mẫu số giảm dần
        public List<Fraction> SortByDenominator(List<Fraction> lst)
        {
            return lst.OrderBy(s => s.B).ToList();
        }

        //Tìm các giá trị bị duplicated trong mảng theo tiêu chí giống nhau
        public List<Fraction> CheckDuplicate(List<Fraction> lst)
        {
            return lst.GroupBy(s => s).Where(gr => gr.Count() > 1).Select(a => a.First()).ToList();

        }
        
        //Tìm các giá trị bị duplicated trong mảng theo tiêu chí bằng nhau
        public List<Fraction> CheckDuplicateValue(List<Fraction> lst)
        {       
            return lst.GroupBy(s => (double) s).Where(gr => gr.Count() > 1).Select(a => a.First()).ToList();
        }

        //Tìm số lượng các fraction có tử là x bất kỳ
        public List<Fraction> CheckEqualsNumerator(List<Fraction> lst, int x)
        {
            return lst.Where(s => s.A == x).ToList();
        }
        
        //Tìm số lượng các fraction có mẫu lớn một số y bất kỳ
        public List<Fraction> CheckGreateThanDenominator(List<Fraction> lst, int y)
        {
            return lst.Where(s => s.B > y).ToList();
        }

        //Lấy kết quả là list lúc đầu nhưng loại bỏ các phần tử có giá trị bằng nhau
        public List<Fraction> MergeNumber(List<Fraction> lst)
        {
            return lst.Distinct().ToList();
        }
    }
}
