namespace NetExercise.Array
{
    public class Exercise06Array
    {
        public static int BinarySearch(int[] arr,int a)
        {
            var l = -1;
            var r = arr.Length;
            var middle = (l + r) >> 1;
            
            while (l < r)
            {
                if (arr[middle] == a)
                {
                    return middle ;
                }

                if (arr[middle] > a)
                {
                    r = middle;
                }
                else
                {
                    l = middle;
                }
                middle = (l + r) >> 1;
            }

            return arr[middle] == a ? middle : -1;
        }
    }
}