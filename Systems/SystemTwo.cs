using System;

namespace Lab_2
{
    internal class SystemTwo : System
    {
        public override double CalculateDerivativeF1X1(double x1, double x2) => -0.2 * x1;

        public override double CalculateDerivativeF1X2(double x1, double x2) => -0.4 * x2;

        public override double CalculateDerivativeF2X1(double x1, double x2) => -0.4 * x1 + 0.1 * x2;

        public override double CalculateDerivativeF2X2(double x1, double x2) => 0.1 * x1;

        public override double CalculateX1(double x1, double x2) => 0.3 - 0.1 * Math.Pow(x1, 2) - 0.2 * Math.Pow(x2, 2);

        public override double CalculateX2(double x1, double x2) => 0.7 - 0.2 * Math.Pow(x1, 2) + 0.1 * x1 * x2;

        public override string ToString() => "\t| 0.3 - 0.1 * x(1)^2 - 0.2 * x(2)^2 - x = 0\n\t\t| 0.7 - 0.2 * x(1)^2 + 0.1 * x(1) * x(2) - x(2) = 0";
    }
}
