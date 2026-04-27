using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    internal class Publikacja
    {

        protected string ilosc_Stron { get; set; }
        protected string tytul { get; set; }
        protected float cena { get; set; } = 0;
        public Publikacja(string ilosc_Stron, string tytul, float cena)
        {
            this.ilosc_Stron = ilosc_Stron;
            this.tytul = tytul;
            this.cena = cena;
        }
        public override string ToString()
        {
            return $"Informacje o publikacji:\n"
                + "Tytuł: " + tytul + "\n"
                + "Ilość stron: " + ilosc_Stron + "\n"
                + "Cena: " + cena;
        }
        public virtual float PrzeliczCene(int iloscEgzemplarzy)
        {
            return cena * iloscEgzemplarzy;
        }
    }
}
