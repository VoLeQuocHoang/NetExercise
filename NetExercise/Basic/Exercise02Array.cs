using System;

namespace NetExercise.Basic
{
    public class Exercise02Array
    {
        public static int SumArray(int[] arr)
        {
            BubbleSort(arr);
            return arr[0] + arr[1] + arr[2];
        }

        private static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] > arr[i])
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