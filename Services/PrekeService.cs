using Layers.Models;
using Layers.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Layers.Services
{
    internal class PrekeService
    {
        PrekiuKategorijaRepository prekesRepository;
        DraudziamosPrekesService draudziamosPrekesService;
        
        public PrekeService() 
        {
            prekesRepository = new PrekiuKategorijaRepository();
            draudziamosPrekesService = new DraudziamosPrekesService();
        }

        public bool AddPreke(string pavadinimas, double kaina, int kiekis)
        {
            bool arPrekeDraudziama = draudziamosPrekesService.ArPrekeYraDraudziama(pavadinimas);
            if (!arPrekeDraudziama)
                prekesRepository.SetPreke(new PrekesKategorija(pavadinimas, kaina, kiekis));
            return arPrekeDraudziama;
        }

        public int NurodytosKainosPrekiuKiekis(double prekesKainaSkaiciavimams)
        {
            int skaiciuojamasPrekiuKiekis = 0;
            // Su foreach vis dėlto geriau, nei šitaip?
            int prekiuKategorijuKiekis = PrekiuKiekisSarase();
            for (int i = 0; i < prekiuKategorijuKiekis; i++)
                if (prekesRepository.GetNurodytaPreke(i).GetKaina() == prekesKainaSkaiciavimams)
                    skaiciuojamasPrekiuKiekis = skaiciuojamasPrekiuKiekis + prekesRepository.GetNurodytaPreke(i).GetKieki();
            return skaiciuojamasPrekiuKiekis;
        }       
        public PrekesKategorija GetPreke(int indeksas)
        {
            return prekesRepository.GetNurodytaPreke(indeksas);
        }
        public List<PrekesKategorija> GetPrekeList()
        {
            return prekesRepository.GetPrekeSarasas();
        }
        public int PrekiuKiekisSarase()
        {
            return GetPrekeList().Count;
        }

    }
}
