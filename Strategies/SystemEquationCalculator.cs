using System;

namespace Lab_2
{
    internal class SystemEquationCalculator : NonLinearCalculatorStrategy
    {
        private readonly System system;
        private int iterationCount;

        public SystemEquationCalculator(System system, double a, double b, double accuracy) : base(a, b, accuracy)
        {
            this.system = system;
            iterationCount = 0;
        }

        public override void Calculation()
        {
            roots = FixedPointIteration();
        }

        private double[] FixedPointIteration()
        {
            if (!IsConvergent()) throw new Exception("Equation is not convergent.");

            double x1_current, x2_current;
            roots[0] = a;
            roots[1] = b;

            int i = 0;
            do
            {
                iterationCount++;
                x1_current = roots[0];
                x2_current = roots[1];

                roots[0] = system.CalculateX1(x1_current, x2_current);
                roots[1] = system.CalculateX2(x1_current, x2_current);

            } while (!IsAccuracyReached(x1_current, x2_current) && i < 10000);

            return roots;
        }

        private bool IsConvergent()
        {
            return Math.Abs(system.CalculateDerivativeF1X1(a, b)) + Math.Abs(system.CalculateDerivativeF2X1(a, b)) < 1
                && Math.Abs(system.CalculateDerivativeF1X2(a, b)) + Math.Abs(system.CalculateDerivativeF2X2(a, b)) < 1;
        }

        private bool IsAccuracyReached(double x1, double x2)
        {
            return Math.Abs(x1 - roots[0]) < accuracy && Math.Abs(x2 - roots[1]) < accuracy;
        }

        public override void PrintRoots()
        {
            for (int i = 0; i < roots.Length; i++)
            {
                Console.WriteLine($"x[{i + 1}]: {roots[i]}");
            }
            Console.WriteLine($"Iterations: {iterationCount}");
        }
    }
}