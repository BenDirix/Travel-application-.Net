﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelNet.Activiteiten
{
    interface IActiviteit
    {
        string Naam { get; set; }
        decimal BerekenPrijs();
    }
}
