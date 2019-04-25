using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_GA1_Aufgabe2
{
    class Volumenlizenz : Artikel
    {
        private int anzahl;

        public Volumenlizenz(int nummer, string bezeichnung, double preis, int anzahl) : base(nummer, bezeichnung, preis)
        {
            if (anzahl < 10)
            {
                this.anzahl = 10;
            }
            else
            {
                this.anzahl = anzahl;
            }
        }

        public override double getPreis()
        {
            return (this.preis * this.anzahl) * 0.9;
        }
    }
}
