namespace NetExercise.Basic
{
    public class Exercise04Array
    {
        public static int SumPrime(int[] n)
        {
            var sum = 0;
            
            for (int i = 0; i < n.Length; i++)
            {
                sum += Prime(n[i]) ? n[i] : 0;
            }

            return sum;
        }
        
        public static bool Prime(int n)
        {
            if (n < 2) return false;
            
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
    
}