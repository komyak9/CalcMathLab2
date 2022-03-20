using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class CoefficientReader
    {
        public double[] ReadCoefficients(Equation equation)
        {
            double[] coefficients = new double[equation.CoefficientCount];
            int lengthCharToSkip = 0;
            string s;

            Console.WriteLine("Enter first coefficient and press Enter: ");
            for (int i = 0; i < equation.CoefficientCount; i++)
            {
                s = Console.ReadLine();
                coefficients[0] = double.Parse(s);

                lengthCharToSkip += s.Length;
                Console.CursorTop--;
                Console.CursorLeft = lengthCharToSkip;
                Console.Write(equation.EquationPartsForPrint[i]);
                lengthCharToSkip += equation.EquationPartsForPrint[i].Length;
            }
            Console.WriteLine();
            return coefficients;
        }
    }
}
