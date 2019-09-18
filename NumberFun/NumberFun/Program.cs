using System;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int select;
            string input;
            Console.WriteLine("Select the assignment you wish to check (number 1-6):");
            Console.WriteLine("");

            input = Console.ReadLine();
            Console.WriteLine("");

            if (int.TryParse(input, out select) == true)
            {
                if (select == 1)
                {
                    Squares();
                }
                else if (select == 2)
                {
                    MultiTable();
                }
                else if (select == 3)
                {
                    RandomSet();
                }
                else if (select == 4)
                {
                    CoinToss();
                }
                else if (select == 5)
                {
                    Row();
                }
                else if (select == 6)
                {
                    DiceRoll();
                }
                else
                {
                    Console.WriteLine("Invalid selection, please reboot.");
                }
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

        static void Row()
        {
            Random rnd = new Random();
            int result;

            for (int i = 1; i <= 13; i++)
            {
                result = rnd.Next(11);

                if (result < 5)
                {
                    Console.WriteLine(i + ".    1");
                } else if (result > 6)
                {
                    Console.WriteLine(i + ".    2");
                } else
                {
                    Console.WriteLine(i + ".    X");
                }
            }
        }

        static void DiceRoll()
        {
            Random rnd = new Random();
            int result;
            int sixes = 0;

            Console.WriteLine("Results;");

            for (int i = 1; i <= 1000; i++)
            {
                result = rnd.Next(6);
                result++;

                Console.WriteLine(i + ". " + result);

                if (result == 6)
                {
                    sixes++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Kuutonen arvottiin " + sixes + " kertaa.");
        }
    }
}
