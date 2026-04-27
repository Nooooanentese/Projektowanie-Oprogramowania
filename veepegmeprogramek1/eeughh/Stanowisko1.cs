using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    abstract class Stanowisko1
    {
        protected DateTime data_zatrudnienia { get; set; }
        public Stanowisko1(DateTime data_zatrudnienia)
        {
            this.data_zatrudnienia = data_zatrudnienia;
        }
        public double DodatekAbstrakcyjny()
        {
            TimeSpan czas_pracy = DateTime.Now - data_zatrudnienia;
            int lata_pracy = (int)(czas_pracy.TotalDays / 365);
            return lata_pracy * 0.01;
        }
        public abstract double ObliczPremie();
        public abstract double ObliczWynagrodzenie();
    }
}
