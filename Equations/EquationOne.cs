using System;

namespace Lab_2
{
    public class FirstEquation : Equation
    {
        public override double CalculateValue(double value) => -3 * Math.Pow(value, 3) + value - 11;

        public override string ToString() => "-3 * x^3 + x - 11 = 0";
    }
}
