using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    abstract class Bryla
    {
        protected double h;
        public Bryla(double h)
        {
            this.h = h;
        }
        public abstract double PolePodstawy();
        public abstract double PoleBoczne();
        public double PoleCalkowite()
        {
            return PolePodstawy() + PoleBoczne();
        }
        public double Objetosc()
        {
            return PolePodstawy() * h / 3;
        }
    }
}
