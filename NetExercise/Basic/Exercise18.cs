using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

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
        
        public static bool HappyNumberSolution2(int n)
        {
            var a = n;
            var b = n;
            do
            {
                a = Convert(a);
                b = Convert(Convert(b));

            } while (a != b && a != 1);

            return a == 1;
        }
        
        public static bool HappyNumberSolution3(int n)
        {
            var numbers = new List<int>();
            while (n != 1)
            {
                if (numbers.Contains(n))
                {
                    return false;
                }
                
                numbers.Add(n);
                
                n = Convert(n);
            }

            return true;
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