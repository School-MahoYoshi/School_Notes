using System;

namespace szamla
{
    public abstract class Szamla
    {
        public string Szamlaszam { get; set; }
        public string Tulajdonos { get; set; }
        public decimal Egyenleg { get; set; }
        public double Kamatlab { get; set; }

        public Szamla(string szamlaszam, string tulajdonos, decimal egyenleg)
        {
            Szamlaszam = szamlaszam;
            Tulajdonos = tulajdonos;
            Egyenleg = egyenleg;
        }

        public void Befizetes(decimal osszeg)
        {
            Egyenleg += osszeg;
        }

        public void Kivetes(decimal osszeg)
        {
            if (osszeg <= Egyenleg)
            {
                Egyenleg -= osszeg;
            }
            else
            {
                throw new InvalidOperationException("Nincs elegendő egyenleg a kivételhez.");
            }
        }
        public abstract int Kamatszamitas();
    }
    public class MegtakaritasiSzamla : Szamla
    {
        public MegtakaritasiSzamla(string szamlaszam, string tulajdonos, decimal egyenleg, double kamatlab) : base(szamlaszam, tulajdonos, egyenleg)
        {
            Kamatlab = kamatlab;
        }

        public override int Kamatszamitas()
        {
            return Convert.ToInt32((double)Egyenleg * (1 + Kamatlab));
        }
    }
    public class Folyoszamla : Szamla
    {
        public Folyoszamla(string szamlaszam, string tulajdonos, decimal egyenleg) : base(szamlaszam, tulajdonos, egyenleg)
        {
            
        }

        public override int Kamatszamitas()
        {
            double kamatlab = 0.05;
            return Convert.ToInt32(Math.Round((double)Egyenleg * kamatlab / 100));
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("<=== Megtakarítási számla ===>");
            MegtakaritasiSzamla megt_szamla = new MegtakaritasiSzamla("123456789", "Kovács János", 1000m, 0.027);

            Console.WriteLine($"Számlaszám: {megt_szamla.Szamlaszam}");
            Console.WriteLine($"Tulajdonos: {megt_szamla.Tulajdonos}");
            Console.WriteLine($"Egyenleg: {megt_szamla.Egyenleg}");
            Console.WriteLine($"Kamatláb: {megt_szamla.Kamatlab * 100}%");

            megt_szamla.Befizetes(500m);
            Console.WriteLine($"Új egyenleg befizetés után: {megt_szamla.Egyenleg}");

            Console.WriteLine("<=== Folyószámla ===>");
            Folyoszamla foly_szamla = new Folyoszamla("987654321", "Nagy Péter", 2000m);

            Console.WriteLine($"Számlaszám: {foly_szamla.Szamlaszam}");
            Console.WriteLine($"Tulajdonos: {foly_szamla.Tulajdonos}");
            Console.WriteLine($"Egyenleg: {foly_szamla.Egyenleg}");
            Console.WriteLine($"Kamatláb: {foly_szamla.Kamatlab * 100}%");
            foly_szamla.Kivetes(300m);
            Console.WriteLine($"Új egyenleg kivétel után: {foly_szamla.Egyenleg}");
        }
    }
}