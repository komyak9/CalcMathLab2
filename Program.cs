using System;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NonLinearCalculatorStrategy strategy = null;
            Picker picker = new Picker();

            while (true)
            {
                try
                {
                    switch (picker.PickMode())
                    {
                        case 1:
                            strategy = new SingleEquationCalculator(picker.PickEquation(), picker.PickA(), picker.PickB(), picker.PickAccuracy());
                            break;
                        case 2:
                            strategy = new SystemEquationCalculator(picker.PickSystem(), picker.PickA(), picker.PickB(), picker.PickAccuracy());
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                try
                {
                    strategy.Calculation();
                    strategy.PrintRoots();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                Console.WriteLine("\nWanna continue? yes/no");
                if (Console.ReadLine() != "yes") break;
            }
        }
    }
}
