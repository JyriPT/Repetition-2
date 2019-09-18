using System;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kaikki tehtävät tehty yhteen, tehtävien tarkistus tehdään valikon kautta
            int select;
            string input;
            Console.WriteLine("Select the assignment you wish to check (number 1-6):");
            Console.WriteLine("");
            //Laitetaan käyttäjän valinta string arvoon
            input = Console.ReadLine();
            Console.WriteLine("");
            //Käsitellään edellä annettu arvo.
            //Jos mahdollista muuttaa int arvoksi, tarkistetaan mikä numero.
            //Jos annettu arvo ei ole numero väliltä 1-6, mitään ei tapahdu.
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
        
        //Neliöjuurten laskenta.
        static void Squares()
        {
            //Kirjoitetaan taulukko aluilleen.
            Console.WriteLine("Luku         Neliöjuuri");
            //Toistorakenne käydään läpi 10 kertaa.
            //Jokaisella kierroksella tulostetaan nykyisen kierroksen numero ja sen numeron neliöjuuri.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "         " + Math.Round(Math.Sqrt(i), 2));
            }
        }
        //Kertotaulujen tulostus.
        static void MultiTable()
        {
            //Ensimmäinen looppi toistaa toisen loopin 9 kertaa.
            for (int i = 1; i <= 9; i++)
            {
                //Toinen looppi kiertää yhdeksän kertaa.
                //Tulostaa molempien looppien kierrosnumeron ja niiden tulon.
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }
            }
        }
        //Satunnaisten sarjojen tulostus.
        static void RandomSet()
        {
            Random rnd = new Random();

            //Looppi toistuu 5 kertaa, tulostaa jokaisella kierroksella 5 satunnaista numeroa ja nykyisen kierroksen numeron.
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Rivi " + i + "       " + rnd.Next(51) + ", " + rnd.Next(51) + ", " + rnd.Next(51) + ", " + rnd.Next(51) + ", " + rnd.Next(51) + ".");
            }
        }
        //Kolikon heitto.
        static void CoinToss()
        {
            string input;
            int result;
            int heads = 0;
            int tails = 0;
            Random rnd = new Random();

            //Pyydetään kolikonheittojen määrää, laitetaan lopputulos aluilleen.
            Console.WriteLine("How many coinflips?");
            input = Console.ReadLine();
            //Tarkistetaan onko annettu määrä luku, joka on suurempi kuin nolla.
            //Luodaan samalla muuttuja "n".
            if (int.TryParse(input, out int n) == true && n > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Rahaa on heitetty " + n + " kertaa:");

                //Do-toistorakenne, looppi lähtee päälle ja pysyy päällä kun käyttäjän antama luku on suurempi kuin nolla.
                do
                {
                    //Varsinainen "kolikon heitto", tulostaan arvon 1 tai 0.
                    result = rnd.Next(2);
                    //Kirjataan tulos.
                    if (result == 1)
                    {
                        heads++;
                    }
                    else if (result == 0)
                    {
                        tails++;
                    }
                    //Pienennetään käyttäjän antama numero yhdellä, näin looppi päättyy joskus.
                    n--;

                } while (n > 0);
                //Tulostetaan tulos.
                Console.WriteLine("Klaavoja tuli " + tails + " ja kruunuja " + heads + ".");
            } else
            {
                Console.WriteLine("Invalid input, please reboot.");
            }
        }
        //Vakioveikkausrivin tulostus.
        static void Row()
        {
            Random rnd = new Random();
            int result;

            //Looppi käydään läpi 13 kertaa. 
            for (int i = 1; i <= 13; i++)
            {
                //Generoidaan uusi satunnainen luku väliltä 0-10.
                result = rnd.Next(11);
                //Tarkastellaan generoitua lukua.
                //Tulostaa eri viestin arvoille 0-4, 5-6, 7-10.
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
        //Nopanheitto.
        static void DiceRoll()
        {
            Random rnd = new Random();
            int result;
            int sixes = 0;

            Console.WriteLine("Results;");

            //Looppi käydään läpi 1000 kertaa.
            for (int i = 1; i <= 1000; i++)
            {
                //Generoi arvon 0-5, lisätään siihen 1, jotta saadaan arvo väliltä 1-6, tulostetaan.
                result = rnd.Next(6);
                result++;
                
                Console.WriteLine(i + ". " + result);
                //Jos arvo oli 6, kirjataan se ylös.
                if (result == 6)
                {
                    sixes++;
                }
            }
            //Tulostetaan tulokset.
            Console.WriteLine();
            Console.WriteLine("Kuutonen arvottiin " + sixes + " kertaa.");
        }
    }
}
