using System;

namespace NetExercise.Basic
{
    public class Exercise09
    {
        public static float SquareRoot(float a)
        {
            var result = 1.0f;
            
            while (Absolute(result*result - a) / a >= 0.0001)
            {
                result = (a / result - result) / 2 + result;
            }

            return (float)Math.Round(result,4);
        }

        public static float Absolute(float x)
        {
            
            if (x < 0)
            {
                return x * (-1);
            }
            else
            {
                return x;
            }
            
        }
    }
}