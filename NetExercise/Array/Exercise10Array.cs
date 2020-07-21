using System;

namespace NetExercise.Array
{
    public class Exercise10Array
    {
        public static int SumSquareNumber(int[] arr)
        {
            int sum = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckSquareNumber(arr[i]))
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
        
        public static bool CheckSquareNumber(int n)
        {
            var number =(int) Math.Sqrt(n);
            return (number * number == n);
        }
    }
}