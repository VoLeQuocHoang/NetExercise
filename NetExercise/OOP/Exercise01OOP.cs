namespace NetExercise.OOP
{
    public class Fraction
    {
        private int i;

        public Fraction(int numerator , int denominator)
        {
            this.a = numerator;
            this.b = denominator;
        }

        public override int GetHashCode()
        {
            return i;
        }
        

        public override bool Equals(object? obj)
        {
            
            if (obj == null || !(obj is Fraction))
            {
                return false;
            }
            else
            {
                return ((i == ((Fraction) obj).i)&&(a == ((Fraction) obj).a)&&(b == ((Fraction) obj).b));
            }
            
        }

        public static bool operator==(Fraction n, Fraction m)
        {
            
            if (n.a == m.a || n.b == m.b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Fraction n, Fraction m)
        {
            return !(n == m);
        }
        
        public override string ToString()
        {
            return a.ToString()+"/"+b.ToString();
        }
        
        
        private double a;
        public double A
        {
            get => a;
             private set => a = value;
        }

        private double b;

        public double B
        {
            get => b;
            private set => b = value;
        }
    }
}