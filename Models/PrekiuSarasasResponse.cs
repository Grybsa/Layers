using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Models
{
    internal class PrekiuSarasasResponse
    {
        DateTime siandienosData = DateTime.Today;
        List<PrekesKategorija> PrekiuSarasas = new List<PrekesKategorija>();
        public void SetPrekiuSarasas(List<PrekesKategorija> prekiuSarasas)
        {
            PrekiuSarasas = prekiuSarasas;
        }
        public DateTime getSiandienosData()
        {
            return siandienosData;
        }
        public PrekesKategorija getPreke(int i)
        {
            return PrekiuSarasas[i];
        }

    }
}
