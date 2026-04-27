using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    internal class ZadanieTekstowe
    {
        public List<string> Slowa { get; set; }
        public ZadanieTekstowe(List<string> slowa)
        {
            Slowa = slowa;
        }
        public void PobierzDoTablicy(string sciezka)
        {
            string[] linie = System.IO.File.ReadAllLines(sciezka);
            Slowa = new List<string>();
            foreach (string linia in linie)
            {
                string[] podzielone = linia.Split(' ');
                foreach (string slowo in podzielone)
                {
                    Slowa.Add(slowo);
                }
            }
        }
        public int PoliczSamogloski()
        {
            int liczbaSamoglosek = 0;
            foreach(string slowo in Slowa)
            {
                foreach(char znak in slowo)
                {
                    if ("aeiouyAEIOUY".Contains(znak))
                    {
                        liczbaSamoglosek++;
                    }
                }
            }
            return liczbaSamoglosek;
        }
        public int PoliczSpolgloski()
        {
            int liczbaSpolglosek = 0;
            foreach (string slowo in Slowa)
            {
                foreach (char znak in slowo)
                {
                    if ("bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".Contains(znak))
                    {
                        liczbaSpolglosek++;
                    }
                }
            }
            return liczbaSpolglosek;
        }
    }
}
