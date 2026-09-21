using System;
using System.Linq;
using System.Collections.Generic;

namespace fodor_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kiir();
            //udvozles("Csak Süsü");

            //Console.WriteLine($"2 + 5 = {osszead(2, 5)}");
            //testtomeg_index();
            //dobokocka();
            tombok_bejarasa();

        }

        #region Függvények 
        static void kiir()
        {
            Console.WriteLine("Hello");
        }

        static void udvozles(string nev)
        {
            Console.WriteLine($"Üdvözöllek {nev}!");
        }
        static int osszead(int a, int b)
        {
            return a + b;
        }
        #endregion
        
        #region Switch
        static void testtomeg_index()
        {
            #region Bekérés
            Console.WriteLine("Kérem a testsúlyát (kg): ");
            double suly = double.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Kérem a testmagasságát (cm): ");
            double mag = double.Parse(Console.ReadLine() ?? "") / 100;
            #endregion

            double bmi = suly/(mag * mag);
            Console.WriteLine($"A BMI-d: {bmi}");
            switch (bmi)
            {
                case double n when (n < 18.5):
                    Console.WriteLine("Soványság");
                    break;
                case double n when (n < 25.0):
                    Console.WriteLine("Normál");
                    break;
                case double n when (n < 30.0):
                    Console.WriteLine("Túlsúly");
                    break;
                default:
                    Console.WriteLine("Elhízás");
                    break;
            }
        }
        #endregion
    
        #region While
        static void dobokocka()
        {
            bool cont = true;
            Random rnd = new Random();
            while (cont)
            {
                int n = rnd.Next(1, 7);
                Console.Write("Adj meg egy számot 1 és 6 között: ");
                int guess = int.Parse(Console.ReadLine() ?? "");
                if (n == guess)
                {
                    Console.WriteLine("Eltaláltad!");
                }
                else
                {
                    Console.WriteLine($"Nem találtad el, a szám {n} volt");
                }

                Console.WriteLine("Akarsz-e még játszani? [i/n]");
                string inp = (Console.ReadLine() ?? "").ToLowerInvariant();

                if (inp != "i")
                {
                    cont = false;
                } 
            }
        }
        #endregion
    
        #region Összetett adattípusok
        static void tombok_bejarasa()
        {
            int[] szamok = { 2, 5, 6, 7, 4, 2, 7 };
            string[] szinek = new string[] {"kík", "pijos", "ződ", "józsaszín"};

        }
        #endregion
    }
}