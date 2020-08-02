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
            var i = 2;
		
            while(a >= i && b >= i)
            {
                if(a % i == 0 && b % i ==0)
                {
                    a /=i;
                    b /=i;
                }
                else
                {
                    i++;
                }
            }
            
            return Tuple.Create(a , b);
        }
    
        private int a;
        public int A { get; private set; }

        private int b;
        public int B { get; private set; }
    }
}