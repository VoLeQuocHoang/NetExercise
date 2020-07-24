using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace NetExercise.Arrays
{
    public class ExerciseArray01
    {
        public static string CountNumberShow(int[] a)
        {
            var listCount = new List<int>();
            var count = 1;
            System.Array.Sort(a);

            for (int i = 1; i < a.Length; i++)
            {
                
                if (a[i] == a[i - 1])
                {
                    count++;
                }
                
                if((a[i] != a[i - 1])||(i == a.Length - 1))
                {
                    if(count >= 2) listCount.Add(a[i-1]);
                    count = 1;
                }
            }

            return string.Join(" ", listCount);
        }
    }
}