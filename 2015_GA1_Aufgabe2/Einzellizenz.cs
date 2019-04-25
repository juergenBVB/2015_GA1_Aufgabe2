using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_GA1_Aufgabe2
{
    class Einzellizenz : Artikel
    {
        public Einzellizenz(int nummer, string bezeichnung, double preis) : base(nummer, bezeichnung, preis)
        {

        }

        public override double getPreis()
        {
            return this.preis * 1.1;
        }
    }
}
