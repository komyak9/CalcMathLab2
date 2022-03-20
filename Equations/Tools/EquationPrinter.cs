using System;

namespace Lab_2
{
    public class EquationPrinter
    {
        public void PrintInfo(Equation equation)
        {
            for (int i = 0; i < equation.CoefficientCount; i++)
            {
                Console.Write(equation.Coefficient[i] + equation.EquationPartsForPrint[i]);
            }
            Console.WriteLine();
        }
    }
}
