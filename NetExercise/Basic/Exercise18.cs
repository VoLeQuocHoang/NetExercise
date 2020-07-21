using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace NetExercise.Basic
{
    public class Exercise18
    {
        public static bool HappyNumber(int n)
        {
            var num = new List<int>();
            while (n != 1)
            {
                if (num.Contains(n))
                {
                    return false;
                }
                
                num.Add(n);
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