namespace NetExercise.Basic
{
    public class Exercise01
    {
        public static int Ucln(int a, int b)
        {
            while (a * b != 0)
            {
                
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
                
            }

            return a + b;
        }

        //Tim Boi Chung Nho Nhat
        public static int Bcnn(int a, int b)
        {
            return (a * b) / Ucln(a, b);
        }
    }
}