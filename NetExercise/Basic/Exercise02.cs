namespace NetExercise.Basic
{
    public class Exercise02
    {
        //(bai 2)Tinh tong cac chu so cua 1 so Nguyen
        public static int TongSoNguyen(int a)
        {
            var tong = 0;
            
            while (a > 0)
            {
                tong += a % 10;
                a /= 10;
            }

            return tong;
        }
    }
}