using System;

namespace NetExercise.Basic
{
    public class Exercise02Array
    {
        public static int SumArray(int[] arr)
        {
            BubbleSort(arr);
            var sum = arr[arr.Length - 1];
            var i = 2;
            var count = 0;
           while (count < 2)
           {
               if (arr[arr.Length - i] != arr[arr.Length - i + 1])
               {
                   sum += arr[arr.Length - i];
                   count++;
               }

               i++;
           }
            return sum;
        }

        private static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[i])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }
    }
}