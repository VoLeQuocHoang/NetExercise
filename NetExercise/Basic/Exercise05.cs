using System.Text;

namespace NetExercise.Basic
{
    public class Exercise05
    {
        public static string FindNumber()
        {
            StringBuilder str = new StringBuilder(40);
            
            for (int i = 10; i <= 99999; i++)
            {
                int temp = 0,j = 0,expo = 0;
                j = i;
                expo = i.ToString().Length;
                
                while (j > 0)
                {
                    //temp += Convert.ToInt32(Math.Pow(j % 10, mu));
                    temp += Exponent(j%10,expo);
                    j /= 10;
                }

                if (temp == i)
                {
                    if (str.Length == 0)
                    {
                        str.Append(i);
                    }
                    else
                    {
                        str.Append(" ");
                        str.Append(i);
                    }
                }
                
            }

            return str.ToString();
        }

        public static int Exponent(int a, int n)
        {
            int exp = 1;
            
            for (int i = 1; i <= n; i++)
            {
                exp *= a;
            }

            return exp;
        }
    }
}