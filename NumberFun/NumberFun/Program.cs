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
                RandomSet();
            } else if (select == 4)
            {
                CoinToss();
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

        static void RandomSet()
        {
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Rivi " + i + "       " + rnd.Next(51) + ", " + rnd.Next(51) + ", " + rnd.Next(51) + ", " + rnd.Next(51) + ", " + rnd.Next(51) + ".");
            }
        }

        static void CoinToss()
        {
            int result;
            int heads = 0;
            int tails = 0;
            Random rnd = new Random();

            Console.WriteLine("How many coinflips?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Rahaa on heitetty " + n + " kertaa:");

            do
            {
                result = rnd.Next(2);

                if (result == 1)
                {
                    heads++;
                } else if (result == 0)
                {
                    tails++;
                }

                n--;

            } while (n > 0);

            Console.WriteLine("Klaavoja tuli " + tails + " ja kruunuja " + heads + ".");
        }
    }
}
