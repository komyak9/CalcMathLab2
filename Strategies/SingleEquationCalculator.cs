using System;

namespace Lab_2
{
    internal class SingleEquationCalculator : NonLinearCalculatorStrategy
    {
        private readonly Equation equation;
        private int bisectionIterationCount;
        private int secantIterationCount;

        public SingleEquationCalculator(Equation equation, double a, double b, double accuracy) : base(a, b, accuracy)
        {
            this.equation = equation;
            bisectionIterationCount = 0;
            secantIterationCount = 0;
        }

        public override void Calculation()
        {
            roots[0] = Bisection();
            roots[1] = Secant();
        }

        private double Bisection()
        {
            if (!IsConvergent()) throw new Exception("Equation is not convergent.");

            double x;
            do
            {
                bisectionIterationCount++;  
                x = (a + b) / 2;

                if (equation.CalculateValue(a) * equation.CalculateValue(x) < 0) b = x;
                else if (equation.CalculateValue(a) * equation.CalculateValue(x) > 0) a = x;
                else return x;

            } while (Math.Abs(equation.CalculateValue(x)) >= accuracy);

            return x;
        }

        private double Secant()
        {
            if (!IsConvergent()) throw new Exception("Equation is not convergent.");

            if (equation.CalculateValue(a) > 0)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            double x = a;
            do
            {
                secantIterationCount++;
                a = x;
                x = a - equation.CalculateValue(a) * (b - a) / (equation.CalculateValue(b) - equation.CalculateValue(a));
            } while (Math.Abs(x - a) >= accuracy);

            return x;
        }

        private bool IsConvergent() => equation.CalculateValue(a) * equation.CalculateValue(b) < 0;

        public override void PrintRoots()
        {
            Console.WriteLine($"\nBisection: {roots[0]}\tIterations: {bisectionIterationCount}");
            Console.WriteLine($"Secant: {roots[1]}\tIterations: {secantIterationCount}");
            Console.WriteLine($"Delta: {Math.Abs(roots[0] - roots[1])}");
        }
    }
}
