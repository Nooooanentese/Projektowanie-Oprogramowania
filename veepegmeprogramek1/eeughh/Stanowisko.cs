using System;
using System.Collections.Generic;

namespace veepegmeprogramek1
{
    internal class Stanowisko
    {
        protected string nazwa { get; set; }
        protected float wynagrodzenie_podstawowe { get; set; }
        protected List<Dodatek> dodatki { get; set; }

        public Stanowisko(string nazwa, float wynagrodzenie_podstawowe, List<Dodatek> dodatki)
        {
            this.nazwa = nazwa;
            this.wynagrodzenie_podstawowe = wynagrodzenie_podstawowe;
            this.dodatki = dodatki;
        }

        public override string ToString()
        {
            return $"Podstawowe informacje o stanowisku:\n"
                + "Nazwa stanowiska: " + nazwa + "\n"
                + "Wynagrodzenie podstawowe: " + wynagrodzenie_podstawowe + "\n"
                + "Dodatki: " + string.Join(", ", dodatki) + "\n" + "Przychód: " + Przychod();
        }

        public virtual float Przychod()
        {
            float suma = wynagrodzenie_podstawowe;
            foreach (var d in dodatki)
            {
                suma += suma * (d.procent / 100);
            }
            return suma;
        }
    }
}