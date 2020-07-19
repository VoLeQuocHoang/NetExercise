namespace NetExercise.Basic
{
    public class Exercise15
    {
        public static int CountNumber(int n)
        {
            var count = 0; 
            var fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            while (fact > 0)
            {
                count++;
                fact /= 10;
            }

            return count;
        }
    }
}