using System;

namespace NetExercise.String
{
    public class Exercise04String
    {
        public static int SumNumbers(string s)
        {
            var sum = 0;
            var digit = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                
                var isDigit = Char.IsDigit(s[i]);
                if (isDigit)
                {
                    digit = digit * 10 + (s[i] - '0');
                }

                if (!isDigit||(i == s.Length -1))
                {
                    sum += digit;
                    digit = 0;
                }
            }

            return sum;
        }
    }
}