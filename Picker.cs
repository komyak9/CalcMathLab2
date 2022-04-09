using System;

namespace Lab_2
{
    public class Picker
    {
        private readonly Equation[] equations = { new FirstEquation(), new ThirdEquation(), new FifthEquation() };
        private readonly System[] systems = { new SystemOne(), new SystemTwo() };

        public int PickMode()
        {
            Console.Write("Please, choose a calculation mode.\n\t1 Nonlinear equation\n\t2 System of nonlinear equations\nYour choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1 || choice == 2)
                return choice;
            else
                throw new Exception("Wrong mode choice.");
        }

        public Equation PickEquation()
        {
            Console.WriteLine("Please, choose an equation. You can choose among: ");
            for (int j = 0; j < equations.Length; j++)
                Console.WriteLine($"\t{j + 1}: {equations[j]}");

            Console.Write("Input number of the equation: ");
            int choice = int.Parse(Console.ReadLine());


            if (choice > equations.Length || choice < 1)
                throw new Exception("Wrong equation choice.");
            else
                return equations[choice - 1];
        }

        public System PickSystem()
        {
            Console.WriteLine("Please, choose a system of equations. You can choose among: ");
            for (int j = 0; j < systems.Length; j++)
                Console.WriteLine($"\t{j + 1}: {systems[j]}");

            Console.Write("Input number of the system: ");
            int choice = int.Parse(Console.ReadLine());


            if (choice > systems.Length || choice < 1)
                throw new Exception("Wrong equation choice.");
            else
                return systems[choice - 1];
        }

        public double PickA()
        {
            while (true)
            {
                try
                {
                    Console.Write("Please, enter a: ");
                    return double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong input!");
                }
            }
        }

        public double PickB()
        {
            while (true)
            {
                try
                {
                    Console.Write("Please, enter b: ");
                    return double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong input!");
                }
            }
        }

        public double PickAccuracy()
        {
            while (true)
            {
                try
                {
                    Console.Write("Please, enter accuracy: ");
                    return double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong input!");
                }
            }
        }
    }
}
