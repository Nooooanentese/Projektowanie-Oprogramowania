using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    internal class Osoba
    {
        protected string Imie { get; set; }
        protected string Nazwisko { get; set; }
        protected char Plec { get; set; }
        protected DateTime DataUrodzenia { get; set; }
        public Osoba(string imie, string nazwisko, char plec, DateTime dataUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Plec = plec;
            DataUrodzenia = dataUrodzenia;
        }

        public override string ToString()
        {
            return Imie + " " + Nazwisko + "\n"
                + "Data urodzenia: " + DataUrodzenia.ToString("D");
        }
    }
}
