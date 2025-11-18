using Layers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Repository
{
    internal class PrekeRepository
    {
        List<PrekesKategorija> PrekiuSarasas = new List<PrekesKategorija>();
        List<string> DraudziamuPrekiuSarasas = new List<string>();
        public PrekeRepository() {  }
        public void setPreke(PrekesKategorija preke)
        {
           PrekiuSarasas.Add(preke); 
        }
        public void setDraudziamaPreke(string prekesPavadinimas)
        {
            DraudziamuPrekiuSarasas.Add(prekesPavadinimas);
        }
        public PrekesKategorija getNurodytaPreke(int prekesIndeksas)
        {
            return PrekiuSarasas[prekesIndeksas];
        }
        public string getNurodytaDraudziamaPreke(int prekesIndeksas)
        {
            return DraudziamuPrekiuSarasas[prekesIndeksas];
        }
        public List<PrekesKategorija> getPrekeList() 
        { 
            return PrekiuSarasas; 
        }
        public List<string> getDraudziamuPrekiuList()
        {
            return DraudziamuPrekiuSarasas;
        }
    }
}
