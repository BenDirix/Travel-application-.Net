using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Verblijven
{
    class Appartement : Verblijf
    {
        public Appartement()
        {
            BeschikbareVerblijfsFormules = new List<Formule>
            {
                Formule.Ontbijt,
                Formule.HalfPension
            };
        }
        public decimal SchoonmaakPrijs { get; set; }
        public bool Lift { get; set; }

        public override decimal BerekenVerblijfsPrijs(int aantalDagen, Formule gekozenFormule)
        {
            if (!BeschikbareVerblijfsFormules.Contains(gekozenFormule))
                throw new Exception($"De verblijfsformule {gekozenFormule} is foutief voor een appartement, geef één van de beschikbare formules op!");

            var prijs = (aantalDagen * BasisPrijsPerDag) + ((int)gekozenFormule * aantalDagen) + SchoonmaakPrijs;
            
            if (ToeslagSingle)
                prijs += (5 * aantalDagen);

            return prijs;
        }
    }
}
