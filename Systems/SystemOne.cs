using System;

namespace Lab_2
{
    internal class SystemOne : System
    {
        public override double CalculateDerivativeF1X1(double x1, double x2) => (x2 + 5) / (4 * Math.Pow((x1 * (x2 + 5) - 1) / 2, 1 / 2.0));

        public override double CalculateDerivativeF1X2(double x1, double x2) => x1 / (4 * ((x1 * (x2 + 5) - 1) / 2));

        public override double CalculateDerivativeF2X1(double x1, double x2) => (1 + (3 * Math.Log(Math.E) / x1)) / (2 * Math.Pow(x1 + 3 * Math.Log(x1, 10), 1 / 2.0));

        public override double CalculateDerivativeF2X2(double x1, double x2) => 0;

        public override double CalculateX1(double x1, double x2) => Math.Sqrt((x1 * (x2 + 5) - 1) / 2);

        public override double CalculateX2(double x1, double x2) => Math.Sqrt(x1 + 3 * Math.Log(x1, 10));

        public override string ToString() => "\t| 2 * x(1)^2 - x(1) * x(2) - 5 * x(1) + 1 = 0\n\t\t| x(1) + 3 * log(x(1)) - x(2)^2 = 0";
    }
}
