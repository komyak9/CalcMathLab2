using System;

namespace Lab_2
{
    internal class FifthEquation : Equation
    {
        public override double CalculateValue(double value) => Math.Pow(value, 2) - value - 7;

        public override string ToString() => "x^2 - x - 7 = 0";
    }
}
