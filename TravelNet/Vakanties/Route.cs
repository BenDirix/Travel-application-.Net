using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelNet;
using TravelNet.Verblijven;

namespace TravelNet.Vakanties
{
    class Route
    {
        public string Vertrekpunt { get; set; }
        public string Eindpunt { get; set; }
        public Verblijf GekozenVerblijfsType { get; set; }

        public Formule GekozenFormule { get; set; }

        public override string ToString()
        {
            return $"     {Vertrekpunt,-13}- {Eindpunt,-12} {GekozenFormule,-15}";
        }       

    }
}
