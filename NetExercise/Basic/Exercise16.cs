using System.Collections.Generic;
using System.Text;

namespace NetExercise.Basic
{
    public class Exercise16
    {
        public static bool CheckNumber(int n)
        {
            for (int i = 2; i <= 5; i++)
            {
                while (n % i == 0)
                {
                    n /= i;
                }
            }

            return (n < 2);
        }
        
    }
}