using Layers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Repository
{
    internal class PrekiuKategorijaRepository
    {
        List<PrekesKategorija> PrekiuSarasas = new List<PrekesKategorija>();
        List<string> DraudziamuPrekiuSarasas = new List<string>();
        public PrekiuKategorijaRepository() {  }
        public void SetPreke(PrekesKategorija preke)
        {
           PrekiuSarasas.Add(preke); 
        }
        public PrekesKategorija GetNurodytaPreke(int prekesIndeksas)
        {
            return PrekiuSarasas[prekesIndeksas];
        }
        public List<PrekesKategorija> GetPrekeSarasas() 
        { 
            return PrekiuSarasas; 
        }
    }
}
