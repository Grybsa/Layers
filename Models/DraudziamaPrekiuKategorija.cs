using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Models
{
    internal class DraudziamaPrekiuKategorija
    {
        string draudziamaPrekiuKategorija;
        
        public DraudziamaPrekiuKategorija(string draudziamaPrekiuKategorija) 
        {
            this.draudziamaPrekiuKategorija = draudziamaPrekiuKategorija;
        }
        public string GetDraudziamaPrekiuKategorija()
        {
            return draudziamaPrekiuKategorija;
        }

    }
}
