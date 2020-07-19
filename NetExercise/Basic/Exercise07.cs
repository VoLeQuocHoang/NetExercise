namespace NetExercise.Basic
{
    public class Exercise07
    {
        public static int Factorial(int n)
        {
            int multi = 1;

            for (int i = 1; i <= n; i++)
            {
                multi *= i;
            }

            return multi;
        }
    }
}