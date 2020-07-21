namespace NetExercise.Array
{
    public class Exercise06Array
    {
        public static int BinarySearch(int[] arr,int a)
        {
            var l = -1;
            var r = arr.Length;
            var middle = 0;
            
            if ((arr[0] > a) || (arr[r - 1] < a))
            {
                return -1;
            }
            
            while (l < r)
            {
                middle = (l + r) >> 1;
                
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

            return arr[middle] == a ? middle : -1;
        }
    }
}