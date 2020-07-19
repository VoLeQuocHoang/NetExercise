using System;

namespace NetExercise.Basic
{
    public class Exercise02Array
    {
        public static int SumArray(int[] n)
        {
            
            //Array.Sort(n);
            BubbleSort(n);
            var sum = n[n.Length - 1];
            var quitLoop = false;
            var i = 2;
            var count = 0;
           while (!quitLoop)
           {
               if (n[n.Length - i] != n[n.Length - i + 1])
               {
                   sum += n[n.Length - i];
                   count++;
               }

               i++;
               quitLoop = (count == 2);
           }
            return sum;
        }

        private static int[] BubbleSort(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
                for (int j = n.Length - 1; j > i ; j--)
                {
                    if (n[j] < n[i])
                    {
                        var temp = 0;
                        temp = n[i];
                        n[i] = n[j];
                        n[j] = temp;
                    }
                }

            return n;
        }
    }
}