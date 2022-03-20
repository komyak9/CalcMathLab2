using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class ThirdEquation : Equation
    {
        public override double CalculateValue(double value) => coefficient[0] * Math.Pow(Math.Cos(value * Math.PI / 180), 2) + coefficient[1] * Math.Tan(value * Math.PI / 180) + coefficient[2] * Math.Pow(Math.Sin(value * Math.PI / 180), 2) + coefficient[3];

        public override double CalculateFirstDerivative(double value) => (coefficient[0] * (-2) + coefficient[2] * 2) * Math.Sin(value * Math.PI / 180) * Math.Cos(value * Math.PI / 180) + coefficient[1] / Math.Pow(Math.Cos(value * Math.PI / 180), 2);

        public override double CalculateSecondDerivative(double value) => coefficient[1] * 2 * Math.Tan(value * Math.PI / 180) / Math.Pow(Math.Cos(value * Math.PI / 180), 2) - (coefficient[0] * (-2) + coefficient[2] * 2) * (Math.Pow(Math.Sin(value * Math.PI / 180), 2) - Math.Pow(Math.Cos(value * Math.PI / 180), 2));

        public override string ToString() => "a * (cos(x))^2 + b * tg(x) + c * (sin(x))^2 + d = 0";
    }
}
