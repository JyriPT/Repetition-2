using System;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int select;
            Console.WriteLine("Select the assignment you wish to check (number 1-6):");
            Console.WriteLine("");

            select = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (select == 1)
            {
                Squares();
            } else if (select == 2)
            {
                MultiTable();
            } else if (select == 3)
            {
                Console.WriteLine("This assignment is being worked on.");
            } else if (select == 4)
            {
                Console.WriteLine("This assignment is being worked on.");
            } else if (select == 5)
            {
                Console.WriteLine("This assignment is being worked on.");
            } else if (select == 6)
            {
                Console.WriteLine("This assignment is being worked on.");
            } else
            {
                Console.WriteLine("Invalid selection, please reboot.");
            }
        }

        static void Squares()
        {
            Console.WriteLine("Luku         Neliöjuuri");
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "         " + Math.Round(Math.Sqrt(i), 2));
            }
        }

        static void MultiTable()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }
            }
        }
    }
}
