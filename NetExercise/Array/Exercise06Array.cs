namespace NetExercise.Array
{
    public class Exercise06Array
    {
        public static int BinarySearch(int[] arr,int a)
        {
            var l = 0;
            var r = arr.Length - 1;
            
            while (l < r)
            {
                if (arr[(l + r) / 2] == a)
                {
                    return (l + r) / 2 ;
                }

                if (arr[(l + r) / 2] > a)
                {
                    r = (l + r) / 2;
                }
                else
                {
                    l = (l + r) / 2;
                }
            }

            return arr[l] == a ? l : -1;
        }
    }
}