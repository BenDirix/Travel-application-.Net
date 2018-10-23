using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Vakanties
{
    class Cruise : Vakantie
    {
        public Route Route { get; set; }
        public List<string> AanlegPlaatsen { get; set; }
        public decimal AllInPrijs { get; set; }
        public override decimal BerekenVakantiePrijs()
        {
            var prijs = 0m;
            if(Activiteiten != null)
                prijs = Activiteiten.Sum(activiteit => activiteit.BerekenPrijs());

            prijs += AllInPrijs;            

            return prijs;
        }

        public override void Weergeven()
        {
            base.Weergeven();
            
            Console.WriteLine(Route.ToString() + $"{Route.GekozenVerblijfsType?.BerekenVerblijfsPrijs((TerugkeerDatum-VertrekDatum).Days, Route.GekozenFormule)}");            
            
            Console.WriteLine("   Activiteit(en):");
            AfdrukActiviteiten();
            Console.WriteLine($"Totale prijs: {BerekenVakantiePrijs()}");
        }
    }
}
