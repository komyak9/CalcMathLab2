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
        protected int coefficientCount;
        protected string[] equationPartsForPrint;

        public Equation(int coefficientCount) => this.coefficientCount = coefficientCount;

        public abstract double CalculateValue(double value);

        public abstract double CalculateFirstDerivative(double value);

        public abstract double CalculateSecondDerivative(double value);

        public int CoefficientCount
        {
            get { return coefficientCount; }
        }

        public string[] EquationPartsForPrint
        {
            get { return equationPartsForPrint; }
        }

        public double[] Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; }
        }
    }
}
