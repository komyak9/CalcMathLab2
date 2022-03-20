using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class SecondEquation : Equation
    {
        public override double CalculateValue(double value) => coefficient[0] * value + coefficient[1] * Math.Log(value, 10) + coefficient[2] * Math.Pow(value, 2);

        public override double CalculateFirstDerivative(double value) => coefficient[0] + coefficient[1] / (value * Math.Log(10)) + coefficient[2] * 2 * value;

        public override double CalculateSecondDerivative(double value) => coefficient[2] * 2 - coefficient[1] / (Math.Pow(value, 2) * Math.Log(10));

        public override string ToString() => "a * x + b * lg(x) + c * x^2 = 0";
    }
}
