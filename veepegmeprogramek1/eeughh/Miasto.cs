using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    internal class Miasto
    {
        protected string nazwa { get; set; }
        protected string kraj { get; set; }
        protected float populacja { get; set; } = 0;
        protected float powierzchnia { get; set; } = 0;
        public Miasto(string nazwa, string kraj, float populacja, float powierzchnia)
        {
            this.nazwa = nazwa;
            this.kraj = kraj;
            this.populacja = populacja;
            this.powierzchnia = powierzchnia;
        }
        public virtual float GestoscZaludnienia()
        {
            return populacja / powierzchnia;
        }
        public override string ToString()
        {
            return $"Nazwa: {nazwa}, Kraj: {kraj}, Populacja: {populacja}, Powierzchnia: {powierzchnia}, Gęstość Zaludnienia: {GestoscZaludnienia()}";
        }
    }
}
