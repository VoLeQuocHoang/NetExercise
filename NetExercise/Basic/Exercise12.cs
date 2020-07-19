namespace NetExercise.Basic
{
    public class Exercise12
    {
        public static bool SymmetricNumber(int n)
        {
            var temp = n;
            var a = 0;

            while (temp > 0)
            {
                a = a * 10 + temp % 10;
                temp /= 10;
            }

            return a == n;

        }
    }
}