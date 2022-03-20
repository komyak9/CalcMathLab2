using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class FirstEquation : Equation
    {
        public FirstEquation() : base(3) => equationPartsForPrint = new string[] { " * x^3 + ", " * x + ", " = 0" };

        public override double CalculateValue(double value) => coefficient[0] * Math.Pow(value, 3) + coefficient[1] * value + coefficient[2];

        public override double CalculateFirstDerivative(double value) => coefficient[0] * 3 * Math.Pow(value, 2) + coefficient[1];

        public override double CalculateSecondDerivative(double value) => coefficient[0] * 6 * value;

        public override string ToString() => "a * x^3 +b * x + c = 0";
    }
}
