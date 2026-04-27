using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    internal class Ksiazka : Publikacja
    {
        public string autor { get; set; }
        public string ISBN { get; set; }
        public Ksiazka (string ilosc_Stron, string tytul, float cena, string autor, string ISBN) : base(ilosc_Stron, tytul, cena)
        {
            this.autor = autor;
            this.ISBN = ISBN;
        }
        public override string ToString()
        {
            return base.ToString() + "\n"
                + "Autor: " + this.autor + "\n"
                + "ISBN: " + this.ISBN;
        }
        public override float PrzeliczCene(int iloscEgzemplarzy)
        {
            if (iloscEgzemplarzy > 1000)
            {
                return base.PrzeliczCene(iloscEgzemplarzy) * 0.95f;
            }
            else
            {
                return base.PrzeliczCene(iloscEgzemplarzy);
            }
        }
    }
}
