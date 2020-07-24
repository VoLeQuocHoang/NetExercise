using System;
using System.Text;

namespace NetExercise.String
{
    public class Exercise10String
    {
        public static Tuple<string, string> SplitName(string s)
        {
            var fistname = new StringBuilder();
            var lastname = new StringBuilder();
            var lastspace = s.LastIndexOf(" ");
            for (int i = 0; i < s.Length; i++)
            {
                if (i < lastspace)
                {
                    lastname.Append(s[i]);
                }
                else if (i > lastspace)
                {
                    fistname.Append(s[i]);
                }
            }
            
            return Tuple.Create(lastname.ToString(),fistname.ToString());
        }
    }
}