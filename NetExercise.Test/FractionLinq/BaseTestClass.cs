using System.Collections.Generic;
using NetExercise.FractionLinq;

namespace NetExercise.Test.FractionLinq
{
    public class BaseTestClass
    {
        protected readonly List<Fraction> Fractions = new List<Fraction>()
        {
            new Fraction(1, 2),
            new Fraction(1, 3),
            new Fraction(2, 3),
            new Fraction(5, 3),
            new Fraction(6, 3),
            new Fraction(4, 3),
            new Fraction(7, 3),
            new Fraction(7, 4),
            new Fraction(7, 9),
            new Fraction(7, 10),
            new Fraction(8, 2),
            new Fraction(8, 3),
            new Fraction(10, 3),
            new Fraction(10, 3),
            new Fraction(10, 7),
            new Fraction(10, 11),
            new Fraction(10, 33),
        };
    }
}