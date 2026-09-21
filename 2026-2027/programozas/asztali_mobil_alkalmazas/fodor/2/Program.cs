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
        }
    }
}