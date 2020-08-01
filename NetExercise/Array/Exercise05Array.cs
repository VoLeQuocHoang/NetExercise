using System.Collections;
using System;
using System.Collections.Generic;

namespace NetExercise.Array
{
    public class Exercise05Array
    {
        public static string SequenceNumbers(int[] arr)
        {
            var temp = new List<int>();
            var sequence = new List<int>();
            sequence.Add(arr[0]);
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i-1])
                {
                    sequence.Add(arr[i]);
                }
                
                if((arr[i] <= arr[i-1])||(i == arr.Length -1))
                {
                    if (temp.Count < sequence.Count)
                    {
                        temp.Clear();
                        foreach(var a in sequence)
                        {
                            temp.Add(a);
                        }
                    }
                    sequence.Clear();
                    sequence.Add(arr[i]);
                }
                
            }

            return System.String.Join( " ",temp);
        }
    }
}