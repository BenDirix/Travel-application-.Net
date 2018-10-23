using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Verblijven
{
    abstract class Verblijf
    {
        public string NaamVerblijf { get; set; }

        public List<Formule> BeschikbareVerblijfsFormules { get; set; }
        public decimal BasisPrijsPerDag { get; set; }
        public bool ToeslagSingle { get; set; }

        public abstract decimal BerekenVerblijfsPrijs(int aantalDagen, Formule gekozenFormule);
    }
}
