using System;
using System.Text;

namespace NetExercise.String
{
    public class Exercise02String
    {
        public static string ConvertString(string s)
        {
            StringBuilder st = new StringBuilder(100);
            
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    st.Append(Char.ToUpper(s[i]));
                }
                else
                {
                    if (s[i].Equals('_'))
                    {
                        if ((i + 1 < s.Length)&&(!s[i+1].Equals('_')))
                        {
                            st.Append(Char.ToUpper(s[i + 1]));
                            i++;
                        }
                        else
                        {
                            st.Append(s[i]);
                        }
                        
                    }
                    else
                    {
                        st.Append(s[i]);
                    }
                }
            }

            return st.ToString();
        }
    }
}