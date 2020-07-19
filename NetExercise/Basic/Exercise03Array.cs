using System.Collections.Generic;

namespace NetExercise.Basic
{
    public class Exercise03Array
    {
        public static int DifferenceArray(int[] n)
        {
            var sumEven = 0;
            var sumOdd = 0;
            
            for (int i = 0; i < n.Length; i++)
            {
                
                if (n[i] % 2 == 0)
                {
                    sumEven += n[i];
                }
                else
                {
                    sumOdd += n[i];
                }
            }

            return sumEven - sumOdd;
        }
    }
}