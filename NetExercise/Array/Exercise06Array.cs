namespace NetExercise.Array
{
    public class Exercise06Array
    {
        public static int BinarySearch(int[] arr,int a)
        {
            var l = -1;
            var r = arr.Length;
            
            while (l < r - 1)
            {
                var middle = (l + r) >> 1;
                
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
            }

            return -1;
        }
    }
}
