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

        public bool addPreke(string pavadinimas, double kaina, int kiekis)
        {
            bool arPrekeDraudziama = draudziamosPrekesService.arPrekeYraDraudziama(pavadinimas);
            if (!arPrekeDraudziama)
                prekesRepository.setPreke(new PrekesKategorija(pavadinimas, kaina, kiekis));
            return arPrekeDraudziama;
        }

        public int NurodytosKainosPrekiuKiekis(double prekesKainaSkaiciavimams)
        {
            int skaiciuojamasPrekiuKiekis = 0;
            // Su foreach vis dėlto geriau, nei šitaip?
            int prekiuKategorijuKiekis = prekiuKiekisSarase();
            for (int i = 0; i < prekiuKategorijuKiekis; i++)
                if (prekesRepository.getNurodytaPreke(i).ImtiKaina() == prekesKainaSkaiciavimams)
                    skaiciuojamasPrekiuKiekis = skaiciuojamasPrekiuKiekis + prekesRepository.getNurodytaPreke(i).ImtiKieki();
            return skaiciuojamasPrekiuKiekis;
        }       
        public PrekesKategorija getPreke(int indeksas)
        {
            return prekesRepository.getNurodytaPreke(indeksas);
        }
        public int prekiuKiekisSarase()
        {
            return getPrekeList().Count;
        }
        public List<PrekesKategorija> getPrekeList()
        {
            return prekesRepository.getPrekeList();
        }
    }
}
