using Layers.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Repository
{
    internal class DraudziamuPrekiuKategorijosRepository
    {
        List<DraudziamaPrekiuKategorija> DraudziamuPrekiuSarasas = new List<DraudziamaPrekiuKategorija>();

        private void SkaitytiDuomenis()
        {

            foreach (string eilute in File.ReadLines("..\\..\\DraudziamosPrekes.txt"))
            {
                if (!string.IsNullOrWhiteSpace(eilute))
                {
                    DraudziamaPrekiuKategorija draudziamaPreke = new DraudziamaPrekiuKategorija(eilute.Trim());
                    DraudziamuPrekiuSarasas.Add(draudziamaPreke);
                }
            }
        }
        public List<DraudziamaPrekiuKategorija> GetDraudziamaPrekeList()
        {
            SkaitytiDuomenis();
            return DraudziamuPrekiuSarasas;
        }
    }
}
