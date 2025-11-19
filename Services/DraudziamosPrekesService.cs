using Layers.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Services
{
    internal class DraudziamosPrekesService
    {
        List<string> DraudziamuPrekiuSarasas = new List<string>()
        {
            "Bluetooth ausinės ProSound",
            "Paspirtukas ScoooootMax",           
        };
        public bool arPrekeYraDraudziama(string pavadinimas)
        {
            bool rastaDraudziamaPreke = false;
            if (DraudziamuPrekiuSarasas.Contains(pavadinimas)) 
                rastaDraudziamaPreke |= true;
            return rastaDraudziamaPreke;
        }
    }
}
