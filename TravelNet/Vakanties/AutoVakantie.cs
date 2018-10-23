using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Vakanties
{
    class AutoVakantie : Vakantie
    {
        public List<Route> Routes { get; set; }
        public WagenType WagenType { get; set; }

        private decimal _huurPrijs;
        public decimal HuurPrijs
        {
            get { return _huurPrijs; }
            set
            {
                if (WagenType == WagenType.EigenWagen)
                    _huurPrijs = 0m;
                else
                    _huurPrijs = value;
            }
        }

        public override decimal BerekenVakantiePrijs()
        {
            var prijs = 0m;
            if(Routes != null)
                prijs += Routes.Sum(r => r.GekozenVerblijfsType.BerekenVerblijfsPrijs(1, r.GekozenFormule));            

            if(Activiteiten != null)           
                prijs += Activiteiten.Sum(activiteit => activiteit.BerekenPrijs());

            prijs += HuurPrijs;
            return prijs;
        }

        public override void Weergeven()
        {
            base.Weergeven();
            foreach(var route in Routes)
            {
                Console.WriteLine(route.ToString() + $"{route.GekozenVerblijfsType.BerekenVerblijfsPrijs(1, route.GekozenFormule)}");
            }
            Console.WriteLine($"   Huurprijs: {HuurPrijs}");
            Console.WriteLine("   Activiteit(en):");
            AfdrukActiviteiten();
            Console.WriteLine($"Totale prijs: {BerekenVakantiePrijs()}");
        }
    }
}
