using Layers.Controlers;
using Layers.Models;
using Layers.Repository;
using Layers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           // PrekiuServices prekiuServices = new PrekiuServices();
            Constants constants = new Constants();

            PrekeFileInputController   prekesFileInputControler   = new PrekeFileInputController();
            PrekeStringInputController prekeStringInputController = new PrekeStringInputController();
            
            string duomenuFailas = constants.ImtiDuomenuFailoPavadinima();
            string rezultatuFailas = constants.ImtiRezultatuFailoPavadinima();

            Console.Write("Pasirinkite duomenų įvedimo būdą: 1 - iš failo, 2 - iš klaviatūros: ");
            string pasirinkimas = Console.ReadLine();
            bool arTesti = true;
            if (pasirinkimas == "2")
            {
                while (arTesti)
                {
                    prekeStringInputController.IvestiPrekiuStringKategorija();
                    Console.Write("Ar nutraukti įvedimą? (T/N): ");
                    string atsakymas = Console.ReadLine().ToLower();
                    if (atsakymas == "t")
                    {
                        arTesti = false;
                    }
                }
                // čia tik pabandymui ar veikia
                Console.WriteLine(prekeStringInputController.getPrekiuSarasasResponse().getPreke(0).GetPavadinima());
                Console.WriteLine(prekeStringInputController.GetSiandienosData().ToShortDateString());
            }
            else
                if (pasirinkimas == "1")
                {
                prekesFileInputControler.SkaitytiDuomenis(duomenuFailas);

                prekesFileInputControler.IsvalytiFaila();

                prekesFileInputControler.SpausdintiDuomenis(rezultatuFailas, "Pradiniai duomenys: ");

                Console.Write("Įveskite prekių kainą: ");
                double prekiuKategorijosKaina = double.Parse(Console.ReadLine());

                prekesFileInputControler.IsvestiSuskaiciuotaPrekiuKieki(rezultatuFailas, prekiuKategorijosKaina);
                }
            else                    
                {
                        Console.WriteLine("Neteisingas pasirinkimas. Programa baigiama.");
                }

        }
    }
}
