using System.Collections.Generic;

namespace NetExercise.Basic
{
    public class Exercise03Array
    {
        public static int DifferenceArray(int[] n)
        {
            var even = new List<int>();
            var odd = new List<int>();
            var sumEven = 0;
            var sumOdd = 0;
            
            for (int i = 0; i < n.Length; i++)
            {
                
                if (n[i] % 2 == 0)
                {
                    even.Add(n[i]);
                }
                else
                {
                    odd.Add(n[i]);
                }
            }

            foreach (var a in even)
            {
                sumEven += a;
            }

            foreach (var a in odd)
            {
                sumOdd += a;
            }

            return sumEven - sumOdd;
        }
    }
}