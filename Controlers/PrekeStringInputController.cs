using Layers.Models;
using Layers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Controlers
{
    internal class PrekeStringInputController
    {
        PrekeService prekiuServices;
        public PrekeStringInputController()
        {
            prekiuServices = new PrekeService();
        }
        public void IvestiPrekiuStringKategorija()
        {
            Console.Write("Įveskite prekių kategoriją (atskirtą ;): ");
            string prekiuKategorija = Console.ReadLine();
            if (prekiuKategorija != null)
            {
                string[] eiluesDalys = prekiuKategorija.Split(';');
                string prekesPavadinimas = eiluesDalys[0].Trim();
                double prekesKaina = double.Parse(eiluesDalys[1]);
                int prekiuKiekisParduotuveje = int.Parse(eiluesDalys[2]);
                prekiuServices.AddPreke(prekesPavadinimas, prekesKaina, prekiuKiekisParduotuveje);
            }
        }
        /* kodėl man šito čia reikia? Ar nepakanka to, kad jis yra PrekeService?
         * Iš tavo laiško: 
         * "Controleris taip pat tures metoda, kuris grazins sarasa ivestu prekiu." */
        public List<PrekesKategorija> getPrekiuSarasas() // 
        {
            return prekiuServices.GetPrekeList();
        }
    }
}
