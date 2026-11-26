using System.Text;
using System.IO;

namespace Fajlkezeles {
    public class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader("teszt.txt", Encoding.UTF8);
            string? line = sr.ReadLine();

            // line = sr.ReadLine(); // Fejléc átugrás
            while (line != null)
            {
                string[] darabok = line.Split(" ");

                if (darabok != null)
                {
                    Console.WriteLine(string.Join(", ", darabok));
                }
             
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}