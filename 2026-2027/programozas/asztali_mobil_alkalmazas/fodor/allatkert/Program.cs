using System;
using System.Collections.Generic;

namespace Allatkert
{

    abstract class Allatkert
    {
        public string Name { get; set; }   
        public List<string> Allatok { get; set; } = new List<string>();

        public Allatkert(string name)
        {
            Name = name;
        }
        public void AllatHozzaad(string allat)
        {
            Allatok.Add(allat);
        }
        public abstract void AllatokatKezel();
    }
    class Vadaspark : Allatkert
    {
        public int BelepoDij { get; set; }
        public Vadaspark(string name, int belepoDij) : base(name)
        {
            BelepoDij = belepoDij;
        }

        public override void AllatokatKezel()
        {
            Console.WriteLine($"{Name} (vadaspark, belépő: {BelepoDij} Ft):");
            foreach (string allat in Allatok)
            {
                Console.WriteLine($"- {allat} etetése és bemutatása a látogatóknak");
            }
        }
    }
    class Allatmenhely : Allatkert
    {
        public int Orokbeadott { get; set; }
        public Allatmenhely(string name) : base(name)
        {
            Orokbeadott = 0;
        }

        public void Orokbeadas(string allat)
        {
            if (Allatok.Remove(allat))
            {
                Orokbeadott++;
            }
        }
        public override void AllatokatKezel()
        {
            Console.WriteLine($"{Name} (állatmenhely, eddig örökbeadva: {Orokbeadott}):");
            foreach (string allat in Allatok)
            {
                Console.WriteLine($"- {allat} gondozása és gazdakeresés");
            }
        }
    }
    class Akvarium : Allatkert
    {
        public int MedenceSzam { get; set; }
        public Akvarium(string name, int medenceSzam) : base(name)
        {
            MedenceSzam = medenceSzam;
        }
        public override void AllatokatKezel()
        {
            Console.WriteLine($"{Name} (akvárium, medencék száma: {MedenceSzam}):");
            foreach (string allat in Allatok)
            {
                Console.WriteLine($"- {allat} etetése és a víz ellenőrzése");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vadaspark vadaspark = new Vadaspark("Budapesti Vadaspark", 2000);
            vadaspark.AllatHozzaad("oroszlán");
            vadaspark.AllatHozzaad("elefánt");

            Allatmenhely allatmenhely = new Allatmenhely("Reménység Menhely");
            allatmenhely.AllatHozzaad("kutya");
            allatmenhely.AllatHozzaad("macska");

            Akvarium akvarium = new Akvarium("Kék Lagúna Akvárium", 4);
            akvarium.AllatHozzaad("aranyhal");
            akvarium.AllatHozzaad("bohóchal");

            vadaspark.AllatokatKezel();
            allatmenhely.AllatokatKezel();
            akvarium.AllatokatKezel();

            allatmenhely.Orokbeadas("kutya");
            allatmenhely.AllatokatKezel();
        }
    }
}