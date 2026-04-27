using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace veepegmeprogramek1
{
    internal class Kwadrat : Prostokat
    {
        public Kwadrat(float a) : base(a, a)
        {
        }
        public override float Pole()
        {
            return a * a;
        }
        public override float Obwod()
        {
            return 4 * a;
        }
        public override string ToString()
        {
            return $"Kwadrat o boku: {a}, Pole: {Pole()}, Obwód: {Obwod()}";
        }
    }
}
