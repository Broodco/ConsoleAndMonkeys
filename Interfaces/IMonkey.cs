using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAndMonkeys.Interfaces
{
    internal interface IMonkey
    {
        string Name { get; set; }
        List<ITrick> Tricks { get; set; }

        void DoAllTricks();
    }
}
