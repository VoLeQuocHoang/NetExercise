using System.Text;

namespace NetExercise.Basic
{
    public class Exercise04
    {
        public static string Fibonacci(int a)
        {
            if (a < 1)
            {
                return "";
            }
            
            int f0 = 0;
            int f1 = 1;
            int f2 = 1;
            StringBuilder str = new StringBuilder(100);
            str.Append("0 1 1");
            
            while (a > f2)
            {
                f0 = f1;
                f1 = f2;
                f2 = f0 + f1;
                
                if (f2 <= a)
                {
                    str.Append(" ");
                    str.Append(f2);
                }
                
            }
            
            return str.ToString();
        }
    }
}