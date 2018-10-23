using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Verblijven
{
    class Vakantiehuis : Verblijf
    {
        public Vakantiehuis()
        {
            BeschikbareVerblijfsFormules = new List<Formule>
            {
                Formule.Ontbijt
            };
        }
        public decimal SchoonmaakPrijs { get; set; }
        public decimal LinnengoedPrijs { get; set; }

        public override decimal BerekenVerblijfsPrijs(int aantalDagen, Formule gekozenFormule)
        {
            if (!BeschikbareVerblijfsFormules.Contains(gekozenFormule))
                throw new Exception($"De verblijfsformule {gekozenFormule} is foutief voor een Vakantiehuis, geef één van de beschikbare formules op!");

            var prijs = (aantalDagen * BasisPrijsPerDag) + ((int)gekozenFormule*aantalDagen) + SchoonmaakPrijs + LinnengoedPrijs;
            if (ToeslagSingle)
                prijs += (5 * aantalDagen);            

            return prijs;
        }
    }
}
