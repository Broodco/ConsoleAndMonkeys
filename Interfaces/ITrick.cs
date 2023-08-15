using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAndMonkeys.Interfaces
{
    internal interface ITrick
    {
        string Name { get; set; }
        TrickCategory Category { get; set; }
    }

    enum TrickCategory
    {
        Musique,
        Acrobatie
    }
}
