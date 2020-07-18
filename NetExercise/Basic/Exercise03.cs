using System.Text;

namespace NetExercise.Basic
{
    public class Exercise03
    {
        public static string MultiplicationPrimes(int a)
        {
            StringBuilder str = new StringBuilder(50);
            
            for (int i = 2; i <= a; i++)
            {
                while (a%i == 0)
                {
                    
                    if (str.Length == 0)
                    {
                        str.Append(i);
                    }
                    else 
                    {
                        str.Append(" * ");
                        str.Append(i);
                    }
                    
                    a /= i;
                }
            }

            return str.ToString();
        }
    }
}