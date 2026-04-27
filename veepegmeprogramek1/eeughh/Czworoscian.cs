using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    class Czworoscian : Bryla
    {
        private double a;
        public Czworoscian(double a) : base(Math.Sqrt(6) / 3 * a)
        {
            this.a = a;
        }
        public override double PolePodstawy()
        {
            return a * a * Math.Sqrt(3) / 4;
        }
        public override double PoleBoczne()
        {
            return 3 * a * a * Math.Sqrt(3) / 4;
        }
    }
}
