using System;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int select = 0;
            Console.WriteLine("Select the assignment you wish to check (number 1-6):");
            Console.WriteLine("");

            select = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (select == 1)
            {
                Squares();
            } else if (select == 2)
            {
                Console.WriteLine("This assignment is being worked on.");
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
    }
}
