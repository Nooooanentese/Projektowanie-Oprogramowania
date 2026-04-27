using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    class Grafik : Stanowisko1
    {
        private int ilosc_projektow { get; set; }
        public Grafik(DateTime data_zatrudnienia, int ilosc_projektow) : base(data_zatrudnienia)
        {
            this.ilosc_projektow = ilosc_projektow;
        }
        public override double ObliczPremie()
        {
            return ilosc_projektow * 100;
        }
        public override double ObliczWynagrodzenie()
        {
            return 3000 + ObliczPremie() + DodatekAbstrakcyjny() * 3000;
        }
    }
}