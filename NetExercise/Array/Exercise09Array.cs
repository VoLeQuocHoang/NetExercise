using System;

namespace NetExercise.Array
{
    public class Exercise09Array
    {
        // Tạo mảng ngẫu nhiên có n phần tử với giá trị từ 1 đến m
        public static int[] RandomArray(int n, int m)
        {
            Random random = new Random();
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                var check = 0;

                do
                {
                    check = random.Next(1, m+1);
                } 
                while (System.Array.IndexOf(arr, check) > -1);

                arr[i] = check;
            }

            return arr;
            
        }
    }
}