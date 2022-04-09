namespace Lab_2
{
    abstract internal class NonLinearCalculatorStrategy
    {
        protected double[] roots;
        protected double a, b, accuracy;

        public NonLinearCalculatorStrategy(double a, double b, double accuracy)
        {
            roots = new double[2];
            this.a = a;
            this.b = b;
            this.accuracy = accuracy;
        }

        public abstract void Calculation();

        public abstract void PrintRoots();

    }
}
