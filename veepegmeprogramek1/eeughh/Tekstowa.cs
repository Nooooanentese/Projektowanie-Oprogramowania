using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    internal static class Tekstowa
    {
        public static bool Anagramy(string slowo1, string slowo2)
        {
            char[] tab1 = slowo1.ToCharArray();
            char[] tab2 = slowo2.ToCharArray();
            Array.Sort(tab1);
            Array.Sort(tab2);
            string posortowaneSlowo1 = new string(tab1);
            string posortowaneSlowo2 = new string(tab2);
            bool wynik = posortowaneSlowo1 == posortowaneSlowo2;
            if (wynik)
            {
                using (StreamWriter sw = new StreamWriter("anagramy.txt", true))
                {
                    sw.WriteLine(slowo1 + " " + slowo2);
                }
            }
            return wynik;
        }
        public static bool Palindrom(string tekst)
        {
            string bezSpacji = tekst.Replace(" ", "").ToLower();
            char[] tablica = bezSpacji.ToCharArray();
            Array.Reverse(tablica);
            string odwroconyTekst = new string(tablica);
            return bezSpacji == odwroconyTekst;
        }
    }
}
