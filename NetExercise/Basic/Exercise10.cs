using System;

namespace NetExercise.Basic
{
    public class Exercise10
    {
        public static float diff(float x, float n)
        {
            return x * x * x - n;
        }

        public static float CubeRoot(float n)
        {
            if (n < 0)
            {
                return -CubeRoot(-n);
            }
            else if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            float xl = 0;
            float xr = n < 1 ? 1 : n;
            
            while (xr - xl > 0.00001)
            {
                float xm = (xl + xr) / 2;
                
                if (diff(xm, n) < 0)
                {
                    xl = xm;
                }
                else
                {
                    xr = xm;
                }
            }

            return (float)Math.Round((xr + xl) / 2, 4);
        }
    }
}