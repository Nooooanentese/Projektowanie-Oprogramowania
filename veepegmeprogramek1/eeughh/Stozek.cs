using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    class Stozek : Bryla
    {
        private double r;
        public Stozek(double h, double r) : base(h)
        {
            this.r = r;
        }
        public override double PolePodstawy()
        {
            return Math.PI * r * r;
        }
        public override double PoleBoczne()
        {
            return Math.PI * r * Math.Sqrt(r * r + h * h);
        }
    }
}
