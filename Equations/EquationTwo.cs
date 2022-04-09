using System;

namespace Lab_2
{
    public class ThirdEquation : Equation
    {
        public override double CalculateValue(double value) => Math.Sin(value * Math.PI / 180);

        public override string ToString() => "sin(x) = 0";
    }
}
