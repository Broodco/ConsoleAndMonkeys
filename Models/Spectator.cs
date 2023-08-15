using ConsoleAndMonkeys.Events;
using ConsoleAndMonkeys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleAndMonkeys.Models
{
    internal class Spectator : ISpectator
    {
        public string Name { get; set; }

        public Spectator(string name)
        {
            Name = name;
        }

        public void StartWatchingMonkeyDoingTricks(IMonkey monkey)
        {
            monkey.RaiseTrickExecutionEvent += ReactToMonkeyTrick;
        }

        void ReactToMonkeyTrick(object sender, TrickExecutionEvent e)
        {
            switch (e.Trick.Category) {
                case TrickCategory.Acrobatie:
                    Console.WriteLine("{0} regarde le tour de {1}, et il applaudit.\n", Name, e.MonkeyName);
                    break;
                case TrickCategory.Musique:
                    Console.WriteLine("{0} regarde le tour de {1}, et il siffle.\n", Name, e.MonkeyName);
                    break;
                default:
                    Console.WriteLine("{0} regarde le tour de {1}, et il ne sait quoi faire !\n", Name, e.MonkeyName);
                    break;
            }
        }
    }
}
