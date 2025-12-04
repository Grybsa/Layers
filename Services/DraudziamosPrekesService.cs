using Layers.Models;
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
        List<DraudziamaPrekiuKategorija> DraudziamuPrekiuSarasas = new List<DraudziamaPrekiuKategorija>()
        {
            new DraudziamaPrekiuKategorija("Bluetooth ausinės ProSound"),
            new DraudziamaPrekiuKategorija("Paspirtukas ScoooootMax")
        };
        public bool arPrekeYraDraudziama(string draudziamaKategorija)
        {
            // chatGPT padėjo, aš pats su ciklu būčiau daręs :)
            // arba Equals() užklojęs ir naudojęs contains() (tikriausiai irgi su pagalba)
            return DraudziamuPrekiuSarasas.Any(kategorijosPavadinimas => kategorijosPavadinimas.getDraudziamaPrekiuKategorija() == draudziamaKategorija);
        }
    }
}
