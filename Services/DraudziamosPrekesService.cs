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
        DraudziamuPrekiuKategorijosRepository draudziamuPrekiuSarasas;
        public DraudziamosPrekesService()
        {
            draudziamuPrekiuSarasas = new DraudziamuPrekiuKategorijosRepository();
        }

        //List<DraudziamaPrekiuKategorija> DraudziamuPrekiuSarasas = new List<DraudziamaPrekiuKategorija>()
        //{
        //    new DraudziamaPrekiuKategorija("Bluetooth ausinės ProSound"),
        //    new DraudziamaPrekiuKategorija("Paspirtukas ScoooootMax")
        //};
        //public List<DraudziamaPrekiuKategorija> getDraudziamaPrekeList(string duomenuFailas)
        //{
        //    return 
        //}
        public bool ArPrekeYraDraudziama(string draudziamaKategorija)
        {
            return draudziamuPrekiuSarasas.GetDraudziamaPrekeList().Any(kategorijosPavadinimas => kategorijosPavadinimas.GetDraudziamaPrekiuKategorija() == draudziamaKategorija);
        }
    }
}
