using System;

namespace NetExercise.Basic
{
    public class Exercise10
    {
        public static double CubeRoot(double n)
        {
            if (n < 0)
            {
                return -CubeRoot(-n);
            }
            var xl = 0.0;
            var xr = n;
            
            while (xr - xl > 0.00001)
            {
                var xm = (xl + xr) / 2;
                
                if ((xm * xm * xm - n) < 0)
                {
                    xl = xm;
                }
                else
                {
                    xr = xm;
                }
            }

            return xr;
        }
    }
}