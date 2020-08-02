using System;
using System.Text;
using Microsoft.VisualBasic;
namespace NetExercise.OOP
{
    public class Fraction
    {

        public Fraction(int a , int b)
        {
            this.a = a;
            this.b = b;
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
                    return ((this == fraction) && (GetHashCode() == fraction.GetHashCode()));
                }

                return false;
        }

        public static bool operator==(Fraction n, Fraction m)
        {
            return (n.a * m.b == n.b * m.a);
        }

        public static bool operator !=(Fraction n, Fraction m)
        {
            return !(n == m);
        }
        
        public override string ToString()
        {
            return $"{a}/{b}";
        }

        private int a;
        public int A { get; private set; }

        private int b;
        public int B { get; private set; }
    }
}
