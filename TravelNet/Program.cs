using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelNet.Verblijven;
using TravelNet.Vakanties;
using TravelNet.Activiteiten;

namespace TravelNet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //**********************************************************
                // Hotels
                //**********************************************************
                Hotel albergoNero = new Hotel
                {
                    NaamVerblijf = "Albergo Nero",
                    BasisPrijsPerDag = 80m,
                    ToeslagSingle = true,
                    Internet = true,
                    WellnessPrijs = 0m
                };
                Hotel capella = new Hotel
                {
                    NaamVerblijf = "Capella",
                    BasisPrijsPerDag = 125m,
                    ToeslagSingle = false,
                    Internet = false,
                    WellnessPrijs = null
                };
                Hotel hotelletFrokost = new Hotel
                {
                    NaamVerblijf = "Hotellet Frokost",
                    BasisPrijsPerDag = 120m,
                    ToeslagSingle = true,
                    Internet = true,
                    WellnessPrijs = 100m
                };
                Hotel meniBeach = new Hotel
                {
                    NaamVerblijf = "MeniBeach",
                    BasisPrijsPerDag = 100m,
                    ToeslagSingle = true,
                    Internet = true,
                    WellnessPrijs = 250m
                };

                //**********************************************************
                // Appartementen
                //**********************************************************
                Appartement casaBlanca = new Appartement
                {
                    NaamVerblijf = "Casa Blanca",
                    BasisPrijsPerDag = 80m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 100m,
                    Lift = true
                };
                Appartement parcoVista = new Appartement
                {
                    NaamVerblijf = "Parco Vista",
                    BasisPrijsPerDag = 45m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 80m,
                    Lift = true
                };
                Appartement hviteHus = new Appartement
                {
                    NaamVerblijf = "Hvite Hus",
                    BasisPrijsPerDag = 85m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 75m,
                    Lift = false
                };
                Appartement husetSvart = new Appartement
                {
                    NaamVerblijf = "Huset Svart",
                    BasisPrijsPerDag = 135m,
                    ToeslagSingle = true,
                    SchoonmaakPrijs = 100m,
                    Lift = false
                };

                //**********************************************************
                //Vakantiehuizen
                //**********************************************************
                Vakantiehuis fioriTorre = new Vakantiehuis
                {
                    NaamVerblijf = "Fiori Torre",
                    BasisPrijsPerDag = 100m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 50m,
                    LinnengoedPrijs = 60m
                };
                Vakantiehuis gronnpark = new Vakantiehuis
                {
                    NaamVerblijf = "Gronnpark",
                    BasisPrijsPerDag = 66m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 75m,
                    LinnengoedPrijs = 45m
                };
                Vakantiehuis blomsterTarnet = new Vakantiehuis
                {
                    NaamVerblijf = "Blomster Tarnet",
                    BasisPrijsPerDag = 90m,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 50m,
                    LinnengoedPrijs = 55m
                };
                Vakantiehuis visning = new Vakantiehuis
                {
                    NaamVerblijf = "Visning",
                    BasisPrijsPerDag = 120,
                    ToeslagSingle = false,
                    SchoonmaakPrijs = 100m,
                    LinnengoedPrijs = 100
                };

                //**********************************************************
                //Routes
                //**********************************************************
                Route routeLucca = new Route
                {
                    Vertrekpunt = "Lucca",
                    Eindpunt = "Prato",
                    GekozenVerblijfsType = casaBlanca,
                    GekozenFormule = Formule.Ontbijt
                };
                Route routePrato = new Route
                {
                    Vertrekpunt = "Prato",
                    Eindpunt = "Bologna",
                    GekozenVerblijfsType = albergoNero,
                    GekozenFormule = Formule.Ontbijt
                };
                Route routeBologna = new Route
                {
                    Vertrekpunt = "Bologna",
                    Eindpunt = "Arezzo",
                    GekozenVerblijfsType = parcoVista,
                    GekozenFormule = Formule.HalfPension
                };
                Route routeArezzo = new Route
                {
                    Vertrekpunt = "Arezzo",
                    Eindpunt = "Livorno",
                    GekozenVerblijfsType = fioriTorre,
                    GekozenFormule = Formule.Ontbijt
                };
                Route routeLivorno = new Route
                {
                    Vertrekpunt = "Livorno",
                    Eindpunt = "Firenze",
                    GekozenVerblijfsType = capella,
                    GekozenFormule = Formule.Ontbijt
                };
                Route routeStavanger = new Route
                {
                    Vertrekpunt = "Stavanger",
                    Eindpunt = "EgerSund",
                    GekozenVerblijfsType = hviteHus,
                    GekozenFormule = Formule.Ontbijt
                };
                Route routeEgerSund = new Route
                {
                    Vertrekpunt = "EgerSund",
                    Eindpunt = "Kragera",
                    GekozenVerblijfsType = husetSvart,
                    GekozenFormule = Formule.Ontbijt
                };
                Route routeKragera = new Route
                {
                    Vertrekpunt = "Kragera",
                    Eindpunt = "Porsgrunn",
                    GekozenVerblijfsType = gronnpark,
                    GekozenFormule = Formule.Ontbijt
                };
                Route routePorsgrunn = new Route
                {
                    Vertrekpunt = "Porsgrunn",
                    Eindpunt = "Drammen",
                    GekozenVerblijfsType = blomsterTarnet,
                    GekozenFormule = Formule.Ontbijt
                };
                Route routeDrammen = new Route
                {
                    Vertrekpunt = "Drammen",
                    Eindpunt = "Oslo",
                    GekozenVerblijfsType = visning,
                    GekozenFormule = Formule.Ontbijt
                };

                Route routeOslo = new Route
                {
                    Vertrekpunt = "Oslo",
                    Eindpunt = "Moss",
                    GekozenVerblijfsType = hotelletFrokost,
                    GekozenFormule = Formule.Ontbijt
                };
                Route routeAthene = new Route
                {
                    Vertrekpunt = "Athene",
                    Eindpunt = "Koz",
                    GekozenVerblijfsType = meniBeach,
                    GekozenFormule = Formule.VolPension
                };
                Route routeHelsinki = new Route
                {
                    Vertrekpunt = "Helsinki",
                    Eindpunt = "Helsinki",
                    GekozenVerblijfsType = null,
                    GekozenFormule = Formule.VolPension
                };

                //**********************************************************
                //Activiteiten
                //**********************************************************
                MTB VolwassenFiets = new MTB
                {
                    Naam = "Volwassen fiets",
                    PrijsUitrusting = 20m,
                    HuurFietsPerUur = 10m,
                    AantalUur = 4
                };
                MTB KinderFiets = new MTB
                {
                    Naam = "Kinderfiets",
                    PrijsUitrusting = 15m,
                    HuurFietsPerUur = 7.5m,
                    AantalUur = 3
                };
                Cinema VolwassenCinema = new Cinema
                {
                    Naam = "Volwassen cinema",
                    Inkom = 7.5m,
                    Snoepgoed = 5m
                };
                Cinema KinderCinema = new Cinema
                {
                    Naam = "Kindercinema",
                    Inkom = 5m,
                    Snoepgoed = 5.25m
                };
                Stadsbezoek Athene = new Stadsbezoek
                {
                    Naam = "Athene",
                    PrijsGidsPer10 = 150m,
                    AantalPersonen = 15
                };
                Stadsbezoek Rome = new Stadsbezoek
                {
                    Naam = "Rome",
                    PrijsGidsPer10 = 125m,
                    AantalPersonen = 12
                };
                Stadsbezoek Oslo = new Stadsbezoek
                {
                    Naam = "Oslo",
                    PrijsGidsPer10 = 175m,
                    AantalPersonen = 7
                };

                //**********************************************************
                //VAKANTIES
                //**********************************************************
                var Vakanties = new List<Vakantie>
                {
                    new Cruise
                    {
                        BoekingsNr = 1,
                        Bestemming = Bestemming.Finland,
                        VertrekDatum = new DateTime(2017,08,12),
                        TerugkeerDatum = new DateTime(2017,08,20),
                        AanlegPlaatsen = new List<string>
                        {
                            "Turku", "Rauma",
                            "Vaasa", "Oulu"
                        },
                        AllInPrijs = 6800m,
                        Route = routeHelsinki,
                        Activiteiten = null,
                    },
                    new AutoVakantie
                    {
                        BoekingsNr = 2,
                        Bestemming = Bestemming.Italië,
                        VertrekDatum = new DateTime(2017,05,14),
                        TerugkeerDatum = new DateTime(2017,05,19),
                        WagenType = WagenType.Camper,
                        HuurPrijs = 1000m,
                        Activiteiten = new List<IActiviteit>
                        {
                        Rome, VolwassenCinema,
                        VolwassenCinema, KinderCinema
                        },
                        Routes = new List<Route>
                        {
                        routeLucca, routePrato,
                        routeBologna, routeArezzo,
                        routeLivorno
                        }
                    },
                    new AutoVakantie
                    {
                        BoekingsNr = 3,
                        Bestemming = Bestemming.Noorwegen,
                        VertrekDatum = new DateTime(2017,08,08),
                        TerugkeerDatum = new DateTime(2017,08,14),
                        WagenType = WagenType.Camper,
                        HuurPrijs = 1500m,
                        Activiteiten = new List<IActiviteit>
                        {
                        Oslo, VolwassenFiets,
                        KinderFiets, KinderFiets
                        },
                        Routes = new List<Route>
                        {
                        routeStavanger, routeEgerSund,
                        routeKragera,routePorsgrunn,
                        routeDrammen,routeOslo
                        }
                    },
                    new VliegVakantie
                    {
                        BoekingsNr = 4,
                        Bestemming = Bestemming.Griekenland,
                        VertrekDatum = new DateTime(2017,09,01),
                        TerugkeerDatum = new DateTime(2017,09,15),
                        VliegTicketPrijs = 800m,
                        Activiteiten = new List<IActiviteit>
                        {
                            Athene, VolwassenFiets, VolwassenFiets,
                            KinderFiets, KinderFiets
                        },
                        Route = routeAthene
                    }
                };

                var autovakanties = Vakanties.Where(vakantie => vakantie is AutoVakantie);
                Console.WriteLine("Autovakanties");
                LijnTrekker('=');
                foreach (var autovakantie in autovakanties)
                {
                    autovakantie.Weergeven();
                    LijnTrekker('-');
                }

                var vliegvakanties = Vakanties.Where(vakantie => vakantie is VliegVakantie);
                Console.WriteLine("Vliegvakanties");
                LijnTrekker('=');
                foreach (var vliegvakantie in vliegvakanties)
                {
                    vliegvakantie.Weergeven();
                    LijnTrekker('-');
                }

                var cruises = Vakanties.Where(vakantie => vakantie is Cruise);
                Console.WriteLine("Cruises");
                LijnTrekker('=');
                foreach (var cruise in cruises)
                {
                    cruise.Weergeven();
                    LijnTrekker('-');
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }


        static void LijnTrekker(char teken)
        {
            Console.WriteLine();
            for (int i = 0; i < 80; i++)
            {
                Console.Write(teken);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
