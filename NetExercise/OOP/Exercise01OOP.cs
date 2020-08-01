using System;
using System.Text;
using Microsoft.VisualBasic;
namespace NetExercise.OOP
{
    public class Fraction
    {

        public Fraction(int numerator , int denominator)
        {
            this.a = numerator;
            this.b = denominator;
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
                    return ((GetHashCode() == fraction.GetHashCode() && (a == fraction.a) && (b == fraction.b)));
                }

                return false;
        }

        public static bool operator==(Fraction n, Fraction m)
        {
            return (n.a / m.a == n.b / m.b);
        }

        public static bool operator !=(Fraction n, Fraction m)
        {
            return !(n == m);
        }
        
        public override string ToString()
        {
            return String.Format("{0}/{1}",a,b);
        }

        private int a;
        public int A {
            get { return a; }
            private set { a = value; }
        }

        private int b;
        public int B { 
            get { return b; }
            private set { b = value; }
        }
    }
}
