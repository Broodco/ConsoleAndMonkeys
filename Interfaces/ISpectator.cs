
using ConsoleAndMonkeys.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAndMonkeys.Interfaces
{
    internal interface ISpectator
    {
        string Name { get; }
        void StartWatchingMonkeyDoingTricks(IMonkey monkey);
    }
}
