using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public abstract class Equation
    {
        protected double[] coefficient;
        public abstract double CalculateValue(double value);

        public abstract double CalculateFirstDerivative(double value);

        public abstract double CalculateSecondDerivative(double value);

        public void SetCoefficients(params double[] coefficient)
        {
            this.coefficient = coefficient;
        }
    }
}
