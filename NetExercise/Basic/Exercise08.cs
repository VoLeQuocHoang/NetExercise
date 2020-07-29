using System;

namespace NetExercise.Basic
{
    public class Exercise08
    {
        public static double Pi()
        {
            var pi = 4.0;
            var i = 1;
            var s = -1;
            var t = 4.0 / 3;
            
            while (t > 0.0001)
            {
                pi += s * t;
                s = -s;
                i++;
                t = 4.0 / (2 * i + 1);
            }
 
            return pi;
        }
    }
}