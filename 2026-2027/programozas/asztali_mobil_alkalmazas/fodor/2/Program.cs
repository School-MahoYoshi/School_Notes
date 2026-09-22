using System;
using System.Linq;
using System.Numerics;

namespace fodor2
{
    class Program {
        static void Main(string[] args)
        {
            #region Tömb
            int[] szamok = [ 2, 5, 4, 32, 10, 64 ];
            string[] szinek = new string[] {"red","blue","green"};
            string[] szinek2 = new string[3];
            szinek2 = [ "red", "blue", "green" ];

            int osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }

            osszeg = szamok.Sum();

            Console.WriteLine($"Összeg: {osszeg}");
            #endregion
           
            #region Listák
            List<int> lista1 = new List<int>(8)
            {
                6,
                3,
                2,
                6
            };

            lista1.Remove(6);
            Console.WriteLine(string.Join(' ', lista1.Select(x => x.ToString())));
            #endregion

            #region Dictionary
            Dictionary<string, string> fovaros = new Dictionary<string, string>();
            fovaros.Add("Magyar", "Budapest");
            fovaros.Add("Románia", "Bukarest");
            fovaros.Add("Német", "Berlin");
            fovaros.Add("Svájc", "Bern");

            foreach (KeyValuePair<string, string> kvp in fovaros)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.Write("\nFővárosok: ");
            foreach (string varos in fovaros.Values)
            {
                Console.Write($"{varos}; ");
            }
            #endregion

            #region Feladat
            var aruk = new Dictionary<string, int>
            {
                { "alma", 550 },
                { "körte", 850 },
                { "szilva", 450 },
                { "szőlő", 1100 },
                { "banán", 650 }
            };
            Console.WriteLine($"Legdrágább gyümölcs: {aruk.Max(x => x.Value)} Ft\nLegolcsóbb gyümölcs: {aruk.Min(x => x.Value)}");

            #endregion
        }
    }
}