using System.Collections.Generic;

namespace NetExercise.Basic
{
    public class Exercise04
    {
        public static string Fibonacci(int n)
        {
            var numbers = new List<int>();

            var f1 = 0;
            var f2 = 1;
            
            while (n >= f2)
            {
                numbers.Add(f2);
                
                var temp = f1;
                f1 = f2;
                f2 = temp + f1;
            }

            return string.Join(" ", numbers);
        }
    }
}