using System;

namespace NetExercise.Basic
{
    public class Exercise08
    {
        public static float Pi()
        {
            var Pi = 4f;
            var t = 1f;
            var i = 1;
            var s = -1;
            t = (float)4 / (2 * i + 1);
            
            while (t > 0.0001)
            {
                Pi += s * t;
                s *= (-1);
                i++;
                t = (float)4 / (2 * i + 1);
            }
 
            return (float)Math.Round(Pi,4);
        }
    }
}