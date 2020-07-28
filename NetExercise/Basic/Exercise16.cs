using System.Collections.Generic;
using System.Text;

namespace NetExercise.Basic
{
    public class Exercise16
    {
        public static bool CheckNumber(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    if (i > 5)
                    {
                        return false;
                    }
                    
                    n /= i;
                }
            }

            return (n==1||n==0);
        }
        
    }
}