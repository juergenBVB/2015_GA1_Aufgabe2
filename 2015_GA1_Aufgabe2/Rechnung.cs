using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_GA1_Aufgabe2
{
    class Rechnung
    {
        private Kunde kunde;
        private List<Artikel> artikelliste;
        public Rechnung(Kunde kunde)
        {
            this.kunde = kunde;
            this.artikelliste = new List<Artikel>();
        }

        public double getGesamtbetrag()
        {
            double result = 0;
            foreach(Artikel artikel in this.artikelliste)
            {
                result += artikel.getPreis();
            }

            return result;
        }

        public void setArtikel(Artikel artikel)
        {
            this.artikelliste.Add(artikel);
        }

        public void drucken()
        {
            Console.WriteLine("Kundendaten:");
            Console.WriteLine("Kundennummer: {0}, Name: {1}, Strasse: {2}, Plz: {3}, Ort: {4}", this.kunde.getKundennummer(), this.kunde.getName(), this.kunde.getStrasse(), this.kunde.getPlz(), this.kunde.getOrt());
            Console.WriteLine("Artikelliste:");
            int i = 1;
            foreach (Artikel artikel in this.artikelliste)
            {
                Console.WriteLine("Artikel {0}: Nummer: {1}, Bezeichnung: {2}, Preis: {3}", i, artikel.getNummer(), artikel.getBezeichnung(), artikel.getPreis());
                i++;
            }
            Console.WriteLine("Gesamtbetrag: {0}", this.getGesamtbetrag());
        }
    }
}
