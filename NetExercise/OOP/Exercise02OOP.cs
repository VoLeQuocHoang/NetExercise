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
            return (n.A * m.B == n.B * m.A);
        }

        public static bool operator !=(Fraction n, Fraction m)
        {
            return !(n == m);
        }
        
        public override string ToString()
        {
            return $"{A}/{B}";
        }

        private int a;
        public int A { get; private set; }

        private int b;
        public int B { get; private set; }
    }
}
