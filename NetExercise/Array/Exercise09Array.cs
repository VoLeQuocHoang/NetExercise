using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic;

namespace NetExercise.Array
{
    public class Exercise09Array
    {
        public static string RandomArray(int n)
        {
            Random random = new Random();
            var arr = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                var check = 0;

                do
                {
                    check = random.Next(1, n+1);
                } 
                while (System.Array.IndexOf(arr, check) > -1);

                arr[i] = check;
            }

            return string.Join(", ",arr);
        }
    }
}