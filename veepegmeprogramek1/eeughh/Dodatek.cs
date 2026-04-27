using System;
using System.Collections.Generic;

namespace veepegmeprogramek1
{
    internal class Dodatek
    {
        public string nazwa { get; set; }
        public float procent { get; set; }

        public Dodatek(string nazwa, float procent)
        {
            this.nazwa = nazwa;
            this.procent = procent;
        }

        public override string ToString()
        {
            return nazwa + " (" + procent + "%)";
        }
    }
}