namespace NetExercise.Basic
{
    public class Exercise18
    {
        public static bool HappyNumber(int n)
        {
            while ((n != 1) && (n != 4))
            {
                n = Convert(n);
            }

            return n == 1;
        }
        
        private static int Convert(int n)
        {
            var temp = 0;
            
            while (n > 0)
            {
                temp += Power(n % 10, 2);
                n /= 10;
            }

            return temp;
        }
        
        private static int Power(int a, int n)
        {
            var exp = 1;

            for (var i = 1; i <= n; i++)
            {
                exp *= a;
            }

            return exp;
        }
    }
}