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
                temp += (n % 10 )* (n % 10);
                n /= 10;
            }

            return temp;
        }
        
    }
}