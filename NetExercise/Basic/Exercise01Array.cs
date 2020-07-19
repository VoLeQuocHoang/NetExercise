using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace NetExercise.Basic
{
    public class Exercise01Array
    {
        public static string CountNumberShow(int[] a)
        {
            var listCount = new List<int>();
            var dem = 1;
            Array.Sort(a);

            for (int i = 1; i < a.Length; i++)
            {
                
                if (a[i] == a[i - 1])
                {
                    dem++;
                }
                else
                {
                    if(dem >= 2) listCount.Add(a[i-1]);
                    dem = 1;
                }
            }

            return string.Join(" ", listCount);
        }
    }
}