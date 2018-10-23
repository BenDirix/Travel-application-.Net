using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Activiteiten
{
    class MTB : IActiviteit
    {
        public decimal PrijsUitrusting { get; set; }
        public decimal HuurFietsPerUur { get; set; }
        public int AantalUur { get; set; }

        public string Naam { get; set; }

        public decimal BerekenPrijs()
        {
            return PrijsUitrusting + (HuurFietsPerUur * AantalUur);
        }
    }
}
