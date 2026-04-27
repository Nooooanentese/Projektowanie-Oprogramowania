using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    internal class Prostokat
    {
        protected float a { get; set; }
        protected float b { get; set; }
        public Prostokat(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public virtual float Pole()
        {
            return a * b;
        }
        public virtual float Obwod()
        {
            return 2 * (a + b);
        }
        public override string ToString()
        {
            return $"Prostokąt o bokach: {a} i {b}, Pole: {Pole()}, Obwód: {Obwod()}";
        }
    }
}
