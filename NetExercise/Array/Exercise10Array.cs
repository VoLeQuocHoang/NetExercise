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
            var number = Convert.ToInt32(SquareRoot(Convert.ToDouble(n)));
            return (number * number == n) ? true : false;
        }
        
        public static double SquareRoot(double a)
        {
            var result = 1.0;
            
            while (Absolute(result*result - a) / a >= 0.0001)
            {
                result = (double)(a / result - result) / 2 + result;
            }

            return result;
        }

        public static double Absolute(double x)
        {

            return x > 0 ? x : -x;

        }
    }
}