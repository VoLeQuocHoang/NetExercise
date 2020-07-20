using System.Collections;
using System;
using System.Collections.Generic;

namespace NetExercise.Array
{
    public class Exercise05Array
    {
        public static string SequenceNumbers(int[] arr)
        {
            System.Array.Sort(arr);
            var temp = new List<int>();
            var sequence = new List<int>();
            sequence.Add(arr[0]);
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i-1] + 1)
                {
                    sequence.Add(arr[i]);
                }
                else
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

            return String.Join(" ",temp);
        }
    }
}