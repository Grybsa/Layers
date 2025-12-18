using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Models
{
    internal class PrekesKategorija
    {
        string pavadinimas;
        double kaina;
        int kiekis;
        public PrekesKategorija() { }
        public PrekesKategorija(string pavadinimas, double kaina, int kiekis)
        {
            this.pavadinimas = pavadinimas;
            this.kaina = kaina;
            this.kiekis = kiekis;
        }
        public string GetPavadinima() { return pavadinimas; }
        public double GetKaina() { return kaina; }
        public int    GetKieki() { return kiekis; }
    }
}
