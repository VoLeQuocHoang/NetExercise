namespace NetExercise.OOP
{ 
    public class Fraction
    {
        public int id;

        public Fraction(int numerator , int denominator)
        {
            this.a = numerator;
            this.b = denominator;
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
            return a.ToString()+"/"+b.ToString();
        }

        public void Minimal()
        {
            var temp = 1;
        
            for (int j = 2; j <= a; j++)
            {
                if ((a % j == 0) && (b % j == 0))
                {
                    temp = j;
                }
            }

            a = a / temp;
            b = b / temp;
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