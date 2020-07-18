namespace NetExercise.Basic
{
    public class Exercise17
    {
        public static int FindNumber(int n)
        {
            var num = n;

            while(!(Prime(num) && SymmetricNumber(num)))
            {
                num++;
            }

            return num;
        }

        public static bool Prime(int n)
        {
            if (n < 2) return false;
            
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
        
        public static bool SymmetricNumber(int n)
        {
            var temp = n;
            var a = 0;

            while (temp > 0)
            {
                a = a * 10 + temp % 10;
                temp /= 10;
            }

            return (a == n);

        }
    }
}