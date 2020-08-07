using System.Collections.Generic;
using System.Linq;
using NetExercise.OOP;

namespace NetExercise.FractionLinq
{
    public class Exercise01
    {
        public List<Fraction> GetMaxOf3(List<Fraction> fractions)
        {
            return fractions.OrderByDescending(x => x.A / (double) x.B).Take(3).ToList();
        }
    }
}