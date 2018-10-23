using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Verblijven
{
    class Hotel : Verblijf
    {
        public Hotel()
        {
            BeschikbareVerblijfsFormules = new List<Formule>
            {
                Formule.Ontbijt, Formule.HalfPension,
                Formule.VolPension
            };
        }
        public bool Internet { get; set; }
        public decimal? WellnessPrijs { get; set; }

        public override decimal BerekenVerblijfsPrijs(int aantalDagen, Formule gekozenFormule)
        {
            if (!BeschikbareVerblijfsFormules.Contains(gekozenFormule))
                throw new Exception($"De verblijfsformule {gekozenFormule} is foutief voor een hotel, geef één van de beschikbare formules op!");

            var prijs = (aantalDagen * BasisPrijsPerDag) + ((int)gekozenFormule * aantalDagen);            
            if (ToeslagSingle)
                prijs += (5 * aantalDagen);            
                        
            if (WellnessPrijs != null)
                prijs += (decimal)WellnessPrijs;

            return prijs;
        }
    }
}
