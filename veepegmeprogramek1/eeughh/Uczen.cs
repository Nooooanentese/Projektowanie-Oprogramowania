using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    internal class Uczen : Osoba
    {
        public string klasa { get; set; }
        public Uczen (string imie, string nazwisko, char plec, DateTime dataUrodzenia, string klasa)
            : base(imie, nazwisko, plec, dataUrodzenia)
        {
            this.klasa = klasa;
        }
        public override string ToString()
        {
            return base.ToString() + "\n"
                + "Klasa: " + this.klasa;
        }
    }
}
