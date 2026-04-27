using System;
using System.Collections.Generic;

namespace veepegmeprogramek1
{
    internal class Pracownik : Stanowisko
    {
        public string identyfikator { get; set; }
        public DateTime data_zatrudnienia { get; set; }

        public Pracownik(string nazwa, float wynagrodzenie_podstawowe, List<Dodatek> dodatki, string identyfikator, DateTime data_zatrudnienia)
            : base(nazwa, wynagrodzenie_podstawowe, dodatki)
        {
            this.identyfikator = identyfikator;
            this.data_zatrudnienia = data_zatrudnienia;
        }

        public override string ToString()
        {
            return "Informacje o pracowniku:\n"
                + "Nazwa stanowiska: " + nazwa + "\n"
                + "Wynagrodzenie podstawowe: " + wynagrodzenie_podstawowe + "\n"
                + "Dodatki: " + string.Join(", ", dodatki) + "\n"
                + "Identyfikator: " + identyfikator + "\n"
                + "Data zatrudnienia: " + data_zatrudnienia.ToShortDateString();
        }

        public float WynagrodzenieZalezneOdStazu()
        {
            int lata = (DateTime.Now - data_zatrudnienia).Days / 365;
            float wynik = wynagrodzenie_podstawowe;

            for (int i = 0; i < lata / 10; i++)
            {
                wynik *= 1.1f;
            }

            return wynik;
        }

        public override float Przychod()
        {
            float suma = WynagrodzenieZalezneOdStazu();
            foreach (var d in dodatki)
            {
                suma += suma * (d.procent / 100);
            }
            return suma;
        }
    }
}