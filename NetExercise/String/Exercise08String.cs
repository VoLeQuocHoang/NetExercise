using System.Text;

namespace NetExercise.String
{
    public class Exercise08String
    {
        public static string ConvertString(string s)
        {
           StringBuilder sb = new StringBuilder(100); 

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    sb.Append(s[i]);
                }
                else
                {
                    if (!s[i].Equals(s[i - 1]))
                    {
                        sb.Append(s[i]);
                    }
                }
            }

            return sb.ToString();
        }
    }
}