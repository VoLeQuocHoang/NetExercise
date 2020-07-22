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
                
                if (s[i] >= '0' && s[i] <= '9')
                {
                    digit = digit * 10 + (s[i] - '0');
                }

                if (!(s[i] >= '0' && s[i] <= '9')||(i == s.Length -1))
                {
                    sum += digit;
                    digit = 0;
                }
            }

            return sum;
        }
    }
}