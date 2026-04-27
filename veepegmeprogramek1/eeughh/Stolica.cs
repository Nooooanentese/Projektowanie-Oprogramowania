using System;
using System.Collections.Generic;
using System.Text;

namespace veepegmeprogramek1
{
    internal class Stolica : Miasto
    {
        public DateTime dataOd { get; set; }
        public DateTime dataDo { get; set; }
        public Stolica(string nazwa, string kraj, float populacja, float powierzchnia, DateTime dataOd, DateTime dataDo) : base(nazwa, kraj, populacja, powierzchnia)
        {
            this.dataOd = dataOd;
            this.dataDo = dataDo;
        }
        public int IleLatStolica()
        {
            if (dataDo > dataOd)
            {
                return (dataDo - dataOd).Days / 365;
            }
            else
            {
                return (DateTime.Now - dataOd).Days / 365;
            }
        }
        public override float GestoscZaludnienia()
        {
            return base.GestoscZaludnienia() * 1.1f;
        }
        public override string ToString()
        {
            return base.ToString() + $", Stolica od: {dataOd.ToShortDateString()} do: {(dataDo > DateTime.Now ? "obecnie" : dataDo.ToShortDateString())}, Ilość lat jako stolica: {IleLatStolica()}";
        }
    }
}