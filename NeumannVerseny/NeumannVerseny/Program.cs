using System;
using System.Linq;

namespace NeumannVerseny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Szamok = File.ReadAllLines("szamok.txt").ToList();

            // 1. feladat / a
            
            int elsoszam = 1310438493;
            Szamok.Add("1310438493");
            int hanydarab = 0;
            int oszto = 1;
            List<int> kozosok = new List<int>();

            foreach (var item in Szamok)
            {
                kozosok.Clear();
                oszto = 1;
                double szam = Convert.ToDouble(item);
                while (oszto <= elsoszam && oszto <= szam)
                {
                    if (elsoszam % oszto == 0 && szam % oszto == 0)
                    {
                        kozosok.Add(oszto);
                    }
                    oszto++;
                }
                Console.WriteLine($";{kozosok.Count}");
                if (kozosok.Count == 1)
                {
                    hanydarab++;
                }
                else
                {
                    continue;
                }
                

            }
            Console.WriteLine(hanydarab);




            // 1. feladat / b

            string eredetiSzam = "2354211341";
            int darabszam = 0;
            int joszamjegy = 0;
            char[] szamjegyek = eredetiSzam.ToCharArray();
            List<int> eredetiszamjegyek = new List<int>();
            List<int> vizsgalandoszamjegyek = new List<int>();

            List<int> valami = new List<int>(new int[] {1,2,3 });
            List<int> ize = new List<int>(new int[] { 2,1,3 });

            
            foreach (var item in szamjegyek)
            {
                eredetiszamjegyek.Add(Convert.ToInt32(item));
            }
            eredetiszamjegyek.Sort();


            foreach (var szam in Szamok)
            {
                
                char[] szamjegyk = szam.ToCharArray();
                foreach (var jegy in szamjegyk)
                {
                    vizsgalandoszamjegyek.Add(Convert.ToInt32(jegy));
                }
                vizsgalandoszamjegyek.Sort();

                for (int i = 0; i < vizsgalandoszamjegyek.Count; i++)
                {
                    
                    if (vizsgalandoszamjegyek[i] == eredetiszamjegyek[i])
                    {
                        joszamjegy++;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (joszamjegy == eredetiSzam.Length)
                {
                    vizsgalandoszamjegyek.Clear();
                    darabszam++;
                    joszamjegy = 0;
                    continue;
                }
                else
                {
                    vizsgalandoszamjegyek.Clear();
                    joszamjegy = 0;
                    continue;
                }


            }
            
            Console.WriteLine(darabszam);

        }
    }
}