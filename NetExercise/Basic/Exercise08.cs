using System;

namespace NetExercise.Basic
{
    public class Exercise08
    {
        public static float Pi()
        {
            var pi = 4f;
            var i = 1;
            var s = -1;
            var t = 1f;
            t = (float)4 / (2 * i + 1);
            
            while (t > 0.0001)
            {
                pi += s * t;
                s *= (-1);
                i++;
                t = (float)4 / (2 * i + 1);
            }
 
            return pi;
        }
    }
}