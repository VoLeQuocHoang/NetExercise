namespace NetExercise.Basic
{
    public class Exercise16
    {
        public static bool CheckNumber(int n)
        {
            if (n < 3)
            {
                return false;
            }
            
            if (n % 30 == 0)
            {
                for (int i = 2; i <= n/2; i++)
                {
                    if (n % i == 0)
                    {
                        if ((Prime(i) && (i != 2) && (i != 3) && (i != 5))||(Prime(n / i) && (n / i != 2) && (n / i != 3) && (n / i != 5)))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            return false;
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