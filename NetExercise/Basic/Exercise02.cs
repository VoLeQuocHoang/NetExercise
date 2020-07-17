namespace NetExercise.Basic
{
    public class Exercise02
    {
        public static int SumDigits(int a)
        {
            var sum = 0;
            
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }

            return sum;
        }
    }
}