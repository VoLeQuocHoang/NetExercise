namespace NetExercise.String
{
    public class Exercise06String
    {
        public static string CountCharacter(string s)
        {
            var count = 1;
            string c = "";
            
            for (int i = 0; i < s.Length; i++)
            {
                
                if (i == 0)
                {
                    c += s[i];
                }
                else
                {
                 
                    if (s[i].Equals(s[i - 1]))
                    {
                        count++;
                        if (i == s.Length - 1)
                        {
                            c += count;
                        }
                    }
                    else
                    {
                        
                        if (count > 1)
                        {
                            c += count;
                        }

                        count = 1;
                        c += s[i];
                    }
                }
            }

            return c;
        }
    }
}