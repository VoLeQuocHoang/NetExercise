namespace NetExercise.Basic
{
    public class Exercise06
    {
        public static int SumOfSequence(int n)
        {
            int tong = 0;
            
            for (int i = 1; i <= n; i++)
            {
                tong += i * (i + 1);
            }

            return tong;
        }
    }
}