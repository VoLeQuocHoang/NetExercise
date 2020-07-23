namespace NetExercise.String
{
    public class Exercise05String
    {
        public static bool SymmetricalNumbers(string s)
        {
            
            for (int i = 0; i < s.Length/2; i++)
            {
                if (!s[i].Equals(s[s.Length - i - 1]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}