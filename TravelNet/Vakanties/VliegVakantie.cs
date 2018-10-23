using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Vakanties
{
    class VliegVakantie : Vakantie
    {
        public Route Route { get; set; }

        public decimal VliegTicketPrijs { get; set; }

        public override decimal BerekenVakantiePrijs()
        {
            var prijs = 0m;   
            prijs += Route.GekozenVerblijfsType.BerekenVerblijfsPrijs((TerugkeerDatum - VertrekDatum).Days, Route.GekozenFormule);
            prijs += Activiteiten.Sum(activiteit => activiteit.BerekenPrijs());

            return prijs + VliegTicketPrijs;
        }

        public override void Weergeven()
        {
            base.Weergeven();
            
            Console.WriteLine(Route.ToString() + $"{Route.GekozenVerblijfsType.BerekenVerblijfsPrijs((TerugkeerDatum - VertrekDatum).Days, Route.GekozenFormule)}");
            Console.WriteLine($"   Vliegtuigticket: {VliegTicketPrijs}");
            Console.WriteLine("   Activiteit(en):");
            AfdrukActiviteiten();
            Console.WriteLine($"Totale prijs: {BerekenVakantiePrijs()}");
        }
    }
}
