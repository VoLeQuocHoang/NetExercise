namespace NetExercise.String
{
    public class Exercise08String
    {
        public static string ConvertString(string s)
        {
            string c = "";
            
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    c += s[i];
                }
                else
                {
                    if (!s[i].Equals(s[i - 1]))
                    {
                        c += s[i];
                    }
                }
            }

            return c;
        }
    }
}