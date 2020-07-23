namespace NetExercise.String
{
    public class Exercise09String
    {
        public static bool CheckBarcode(string s)
        {
            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 != 0)
                {
                   sum += (s[i] - '0') * 3;
                }
                else
                {
                    sum += (s[i] - '0');
                }
            }

            return ((sum % 10) == 0);
            
        }
    }
}