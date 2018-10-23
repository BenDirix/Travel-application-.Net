using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelNet;
using TravelNet.Activiteiten;

namespace TravelNet.Vakanties
{
    abstract class Vakantie
    {
        public int BoekingsNr { get; set; }
        public Bestemming Bestemming { get; set; }
        public List<IActiviteit> Activiteiten { get; set; }
        public DateTime VertrekDatum { get; set; }

        private DateTime _terugkeerDatum;
        public DateTime TerugkeerDatum
        {
            get { return _terugkeerDatum; }
            set
            {
                if (VertrekDatum > value)
                {
                    throw new Exception($"Reis met boekingsnr{BoekingsNr}: terugkeerdatum ({TerugkeerDatum.ToShortDateString()}) moet later zijn dan vertrekdatum({VertrekDatum.ToShortDateString()})!");
                }                    
                else
                    _terugkeerDatum = value;
            }
        }

        public abstract decimal BerekenVakantiePrijs();
        public void AfdrukActiviteiten()
        {
            if(Activiteiten != null)
            {
                foreach (var activiteit in Activiteiten)
                    Console.WriteLine($"      {activiteit.Naam} kost:  {activiteit.BerekenPrijs()}");

                var totaalprijs = Activiteiten.Sum(activiteit => activiteit.BerekenPrijs());
                Console.WriteLine($"    Totaal van alle activiteiten: {totaalprijs}");
            }                
            else
                Console.WriteLine("    Totale activiteitsprijs: 0");
        }
        public virtual void Weergeven()
        {
            Console.WriteLine($"Boekingsnr: {BoekingsNr}   Bestemming: {Bestemming}");
            Console.WriteLine($"   Vertrekdatum: {VertrekDatum.ToShortDateString()}    Einddatum: {TerugkeerDatum.ToShortDateString()}");
            
        }

    }
}
