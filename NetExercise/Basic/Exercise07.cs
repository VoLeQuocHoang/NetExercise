namespace NetExercise.Basic
{
    public class Exercise07
    {
        public static int Factorial(int n)
        {
            int sum = 1;

            if (n == 0)
            {
                return sum;
            }
            else if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    sum *= i;
                }
            }

            return sum;
        }
    }
}