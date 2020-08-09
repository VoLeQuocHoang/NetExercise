using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;

namespace NetExercise.FractionLinq
{
    public class Fraction
    {
        public Fraction(int a , int b)
        {
            A = a;
            B = b;
        }

        public Fraction(int a):this(a,1)
        {
        }

        public static List<Fraction> Clone(List<Fraction> lst)
        {
            var lstClone = new List<Fraction>();

            foreach (var a in lst)
            {
                lstClone.Add(new Fraction(a.A, a.B));
            }
            
            return lstClone.ToList();
        }

        public override int GetHashCode()
        {
            var result = 1;
            result = 17 + A;
            result = result * 19 + B;
            
            return result;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Fraction fraction)
            {
               return this == fraction;
            }

            return false;
        }

        public static bool operator==(Fraction n, Fraction m)
        {
            if (n is null && m is null)
            {
                return true;
            }
            else if (!(n is null) && !(m is null))
            {
                n.Minimal();
                m.Minimal();
                
                return n.A * m.B == n.B * m.A;
            }
            else
            {
                return false;
            }
        }

        public static bool operator!=(Fraction n, Fraction m)
        {
            return !(n == m);
        }
    
        public override string ToString()
        {
            return $"{A}/{B}";
        }

        public static Fraction operator+(Fraction n, Fraction m)
        {
            var a = (n.A * m.B) + (n.B * m.A);
            var b = n.B * m.B;
            
            return Minimal(a, b);
        }

        public static Fraction operator-(Fraction n, Fraction m)
        {
            return n + (-1)*(m);
        }

        public static Fraction operator*(Fraction n, Fraction m)
        {
            var a = n.A * m.A;
            var b = n.B * m.B;
            
            return Minimal(a, b);
        }

        public static Fraction operator/(Fraction n, Fraction m)
        {
            return n * (!m);
        }

        public static bool operator>=(Fraction n, Fraction m)
        {
            return n.A * m.B >= n.B * m.A;
        }
        
        public static bool operator<=(Fraction n, Fraction m)
        {
            return (!(n >= m)||(n == m));
        }
        
        public static bool operator>(Fraction n, Fraction m)
        {
            return !(n <= m);
        }
        
        public static bool operator<(Fraction n, Fraction m)
        {
            return !(n >= m);
        }

        public static Fraction operator!(Fraction n)
        {
            return new Fraction(n.B,n.A);
        }
        
        public static explicit operator double(Fraction n)
        {
            return (double) n.A / n.B;
        }

        public static implicit operator Fraction(int n)
        {
            return new Fraction(n);
        }

        public void Minimal()
        {
            var temp = Minimal(A, B);
            A = temp.A;
            B = temp.B;
        }
        
        public static Fraction Minimal(int a, int b)
        {
            var t = Gcd(a, b);

            return new Fraction(a / t, b / t);
        }

        private static int Gcd(int a, int b) //Greatest Common Divisor
        {
            if (b == 0)
            {
                return a;
            }

            return Gcd(b, a % b);
        }
        
        //Linq
        public static Fraction Biggest(List<Fraction> lst)
        {
            return lst.OrderByDescending(s => (double) s).First();
        }    
        
        public static Fraction Smallest(List<Fraction> lst)
        {
            return lst.OrderByDescending(s => (double) s).Last();
        }

        public static Fraction Sum(List<Fraction> lst)
        {
            return lst.Aggregate((s1, s2) => s1 + s2);
        }
        
        public static Fraction Product(List<Fraction> lst)
        {
            return lst.Aggregate((s1, s2) => s1 * s2);
        }
        
        public static List<Fraction> Sort(List<Fraction> lst)
        {
            return lst.OrderBy(s => (double) s).ToList();
        }

        public static List<Fraction> SortByNumerator(List<Fraction> lst)
        {
            foreach (var a in lst.OrderBy(s => s.A).ToList())
            {
                Console.WriteLine(a);
            }
            
            return lst.OrderBy(s => s.A).ToList();
        }
        
        public static List<Fraction> SortByDenominator(List<Fraction> lst)
        {
            foreach (var a in lst.OrderBy(s => s.B).ToList())
            {
                Console.WriteLine(a);
            }
            
            return lst.OrderBy(s => s.B).ToList();
        }

        public static List<Fraction> CheckDuplicate(List<Fraction> lst)
        {
            return lst.GroupBy(s => s).SelectMany(grp => grp.Skip(1)).ToList();

        }
        
        public static List<Fraction> CheckDuplicateValue(List<Fraction> lst)
        {
            var ls = new List<Fraction>();
            var duplicates = lst.GroupBy(s => (double) s).Where(gr => gr.Count()>1);
                
            foreach(var n in duplicates)
            {
                foreach(var a in n)
                {
                    ls.Add(a);
                }
            }

            return ls;
        }

        public static List<Fraction> CheckEqualsNumerator(List<Fraction> lst, int x)
        {
            return lst.Where(s => s.A == x).ToList();
        }
        
        public static List<Fraction> CheckGreateThanDenominator(List<Fraction> lst, int y)
        {
            return lst.Where(s => s.B > y).ToList();
        }

        public static List<Fraction> MergeNumber(List<Fraction> lst)
        {
            return lst.Distinct().ToList();
        }
        //Linq
        public int A { get; private set; }
        public int B { get; private set; }
    }
}