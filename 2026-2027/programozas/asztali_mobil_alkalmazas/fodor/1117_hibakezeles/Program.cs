using System;
using System.IO;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string szoveg = "58a";
                int szam = int.Parse(szoveg);
                Console.WriteLine(szam);
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hiba történt átalakításkor: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            finally
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();       
            }


            try
            {
                
            }
            catch (FileNotFoundException ex)
            {
                
                throw;
            }
            catch (FileLoadException ex)
            {
                
                throw;
            }
        }
    }
}