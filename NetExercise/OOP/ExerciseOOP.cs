using System;
using System.Resources;

namespace NetExercise.OOP
{
    public class Fraction
    {
        public Fraction(int a , int b)
        {
            A = a;
            B = b;
        }

        public Fraction(int a)
        {
            A = a;
            B = 1;
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
            var a = (n.A * m.B) - (n.B * m.A);
            var b = n.B * m.B;
            
            return Minimal(a, b);
        }

        public static Fraction operator*(Fraction n, Fraction m)
        {
            var a = n.A * m.A;
            var b = n.B * m.B;
            
            return Minimal(a, b);
        }

        public static Fraction operator/(Fraction n, Fraction m)
        {
            var a = n.A * m.B;
            var b = n.B * m.A;
            
            return Minimal(a, b);
        }

        public static bool operator>=(Fraction n, Fraction m)
        {
            return n.A * m.B >= n.B * m.A;
        }
        
        public static bool operator<=(Fraction n, Fraction m)
        {
            return n.A * m.B <= n.B * m.A;
        }
        
        public static bool operator>(Fraction n, Fraction m)
        {
            return n.A * m.B > n.B * m.A;
        }
        
        public static bool operator<(Fraction n, Fraction m)
        {
            return n.A * m.B < n.B * m.A;
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
        public int A { get; private set; }
        public int B { get; private set; }
    }
}