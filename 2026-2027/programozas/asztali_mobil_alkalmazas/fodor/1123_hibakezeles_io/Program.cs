using System;
using System.IO;
using System.Collections.Generic;

namespace Program {
    public class NepessegAdat
    {
        public int Helyezes { get; set; }
        public string Varos { get; set; }
        public string Orszag { get; set; }
        public int Nepesseg { get; set; }

        public NepessegAdat(string line)
        {
            string[] parts = line.Split(';');
            Helyezes = int.Parse(parts[0]);
            Varos = parts[1];
            Orszag = parts[2];
            Nepesseg = int.Parse(parts[3]);
        }
    }
    public class Program {
        static void Main(string[] args)
        {
            #region Kivételkezelés
            string szoveg = "2";
            try
            {
                int szam = int.Parse(szoveg);
                Console.WriteLine(10 / szam);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Számot adjál meg!");
            }
            catch (DivideByZeroException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ne nullát adjál meg!");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hiba történt: {ex.Message}");
            }
            finally
            {
                Console.ResetColor();
                Console.WriteLine("Ez mindenképpen lefut");
            }
            #endregion
            #region IO Kivételkezelés
            List<NepessegAdat>? nepessegek = null;
            try
            {
                nepessegek = 
                    File.ReadAllLines("varosok.txt")
                    .Skip(1)
                    .ToList()
                    .ConvertAll(x => new NepessegAdat(x));
            }
            catch (FileNotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Fájl nem található.\n{ex.Message}");
                Console.ResetColor();
                return;
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Konvertálási hiba.\n{ex.Message}");
                Console.ResetColor();
                return;
            }
            catch (UnauthorizedAccessException ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Nem lehet a fájlt megnyitni.\n{ex.Message}");
                Console.ResetColor();
                return;
            }
            catch (Exception)
            {
                throw;
            }

            if (nepessegek == null)
                return;
            Console.WriteLine($"Városok száma: {nepessegek.Count()}");
            
            
            #endregion
        }
    }
}