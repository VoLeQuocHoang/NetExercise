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
            var leng = s.Length - 1;
            
            lastname.Append(s.Substring(0, lastspace));
            fistname.Append(s.Substring(lastspace + 1, leng - lastspace));

            return Tuple.Create(lastname.ToString(),fistname.ToString());
        }
    }
}