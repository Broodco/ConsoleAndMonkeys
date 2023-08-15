using ConsoleAndMonkeys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAndMonkeys.Events
{
    internal class TrickExecutionEvent : EventArgs
    {
        public ITrick Trick { get; set; }
        public string MonkeyName { get; set; }

        public TrickExecutionEvent(ITrick trick, string monkeyName)
        {
            Trick = trick;
            MonkeyName = monkeyName;
        }
    }
}
