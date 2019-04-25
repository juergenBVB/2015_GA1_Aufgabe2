using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_GA1_Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde testKunde = new Kunde(1, "Kunde 1", "Teststrasse 1", 89077, "Ulm");

            Einzellizenz testEinzellizenz = new Einzellizenz(1, "Einzellizenz", 20.0);
            Volumenlizenz testVolumenlizenz = new Volumenlizenz(2, "Volumenlizen", 5.0, 25);


            Rechnung testRechnung = new Rechnung(testKunde);
            testRechnung.setArtikel(testEinzellizenz);
            testRechnung.setArtikel(testVolumenlizenz);

            testRechnung.drucken();

            Console.Read();
        }
    }
}
