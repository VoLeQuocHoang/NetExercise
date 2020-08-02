using System;
using System.Text;
using Microsoft.VisualBasic;

namespace NetExercise.OOP
{
    public class Fraction
    {
        public Fraction(int a , int b)
        {
            A = a;
            B = b;
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
            n.Minimal();
            m.Minimal();
            return (n.A == m.A)&&(n.B == m.B);
        }

        public static bool operator !=(Fraction n, Fraction m)
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
            var temp = Minimal(a, b);
            return new Fraction(temp.Item1, temp.Item2);
        }
        
        public static Fraction operator-(Fraction n, Fraction m)
        {
            var a = (n.A * m.B) - (n.B * m.A);
            var b = n.B * m.B;
            var temp = Minimal(a, b);
            return new Fraction(temp.Item1, temp.Item2);
        }

        public static Fraction operator*(Fraction n, Fraction m)
        {
            var a = n.A * m.A;
            var b = n.B * m.B;
            var temp = Minimal(a, b);
            return new Fraction(temp.Item1, temp.Item2);
        }

        public static Fraction operator/(Fraction n, Fraction m)
        {
            var a = n.A * m.B;
            var b = n.B * m.A;
            var temp = Minimal(a, b);
            return new Fraction(temp.Item1, temp.Item2);
        }

        public void Minimal()
        {
            var temp = Minimal(A, B);
            A = temp.Item1;
            B = temp.Item2;
        }
        
        public static Tuple<int, int> Minimal(int a, int b)
        {
            var temp = 1;
        
            for (int j = 2; j <= a; j++)
            {
                if ((a % j == 0) && (b % j == 0))
                {
                    temp = j;
                }
            }
            
           return Tuple.Create(a / temp, b / temp);
        }
    
        private int a;
        public int A { get; private set; }

        private int b;
        public int B { get; private set; }
    }
}