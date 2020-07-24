using System.Text;

namespace NetExercise.String
{
    public class Exercise06String
    {
        public static string CountCharacter(string s)
        {
            var count = 1;
            var c = new StringBuilder();
            
            for (int i = 0; i < s.Length; i++)
            {
                
                if (i == 0)
                {
                    c.Append(s[i]);
                }
                else
                {
                 
                    if (s[i].Equals(s[i - 1]))
                    {
                        count++;
                        if (i == s.Length - 1)
                        {
                            c.Append(count);
                        }
                    }
                    else
                    {
                        
                        if (count > 1)
                        {
                            c.Append(count);
                        }

                        count = 1;
                        c.Append(s[i]);
                    }
                }
            }

            return c.ToString();
        }
    }
}