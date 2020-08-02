using System;
using System.Text;
using Microsoft.VisualBasic;

namespace NetExercise.OOP
{
    public class Fraction
    {
        public int id;

        public Fraction(int a , int b)
        {
            this.a = a;
            this.b = ;
            id = GetHashCode();
        }

        public override int GetHashCode()
        {
            var result = 1;
            result = 17 + a;
            result = result * 19 + b;
            return result;
        }
    

        public override bool Equals(object? obj)
        {
        
            if (obj is Fraction fraction)
            {
               return ((id == fraction.id && (a == fraction.a) && (b == fraction.b)));
            }

            return false;
        }

        public static bool operator==(Fraction n, Fraction m)
        {
            n.Minimal();
            m.Minimal();
            return ((n.a == m.a)&&(n.b == m.b));
        }

        public static bool operator !=(Fraction n, Fraction m)
        {
            return !(n == m);
        }
    
        public override string ToString()
        {
            return $"{a}/{b}";
        }

        public static Fraction operator+(Fraction n, Fraction m)
        {
            var a = (n.a * m.b) + (n.b * m.a);
            var b = n.b * m.b;
            var temp = Minimal(a, b);
            return new Fraction(temp.Item1, temp.Item2);
        }
        
        public static Fraction operator-(Fraction n, Fraction m)
        {
            var a = (n.a * m.b) - (n.b * m.a);
            var b = n.b * m.b;
            var temp = Minimal(a, b);
            return new Fraction(temp.Item1, temp.Item2);
        }

        public static Fraction operator*(Fraction n, Fraction m)
        {
            var a = n.a * m.a;
            var b = n.b * m.b;
            var temp = Minimal(a, b);
            return new Fraction(temp.Item1, temp.Item2);
        }

        public static Fraction operator/(Fraction n, Fraction m)
        {
            var a = n.a * m.b;
            var b = n.b * m.a;
            var temp = Minimal(a, b);
            return new Fraction(temp.Item1, temp.Item2);
        }

        public void Minimal()
        {
            var temp = Minimal(a, b);
            a = temp.Item1;
            b = temp.Item2;
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