using System;

namespace NetExercise.Basic
{
    public class Exercise09
    {
        public static double SquareRoot(double a)
        {
            var result = 1.0;
            
            while (Absolute(result*result - a) / a >= 0.0001)
            {
                result = (double)(a / result - result) / 2 + result;
            }

            return (double)result;
        }

        public static double Absolute(double x)
        {

            return x > 0 ? x : -x;

        }
    }
}