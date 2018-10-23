using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Activiteiten
{
    class Stadsbezoek : IActiviteit
    {
        public decimal PrijsGidsPer10 { get; set; }
        public int AantalPersonen { get; set; }
        public string Naam { get; set; }

        public decimal BerekenPrijs()
        {            
            var prijs = 0m;

            if (AantalPersonen % 10 == 0)
                prijs = (AantalPersonen / 10) * PrijsGidsPer10;
            else
                prijs = (AantalPersonen / 10 + 1) * PrijsGidsPer10;

            return prijs;
        }
    }
}
