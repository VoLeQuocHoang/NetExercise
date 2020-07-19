namespace NetExercise.Basic
{
    public class Exercise11
    {
        public static int RotateBinary(int n)
        {
            int revs = 0;

            while (n > 0)
            {
                revs <<= 1;
                revs ^= (n & 1);
                n >>= 1;
            }

            return revs;
        }
    }
}