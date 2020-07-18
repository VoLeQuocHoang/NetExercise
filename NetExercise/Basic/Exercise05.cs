using System.Collections.Generic;

namespace NetExercise.Basic
{
    public class Exercise05
    {
        public static string FindNumber()
        {
            var results = new List<int>();

            for (var i = 10; i <= 99999; i++)
            {
                if (Convert(i) == i)
                {
                    results.Add(i);
                }
            }

            return string.Join(" ", results);
        }

        private static int Convert(int n)
        {
            var length  = n.ToString().Length;

            var temp = 0;
            while (n > 0)
            {
                temp += Power(n % 10, length);
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