using ConsoleAndMonkeys.Events;
using ConsoleAndMonkeys.Interfaces;

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

        void ReactToMonkeyTrick(object? sender, TrickExecutionEvent e)
        {
            switch (e.Trick.Category) {
                case TrickCategory.Acrobatie:
                    Console.WriteLine("{0} regarde le tour de {1}, et il applaudit.\n", Name, e.MonkeyName);
                    break;
                case TrickCategory.Musique:
                    Console.WriteLine("{0} regarde le tour de {1}, et il siffle.\n", Name, e.MonkeyName);
                    break;
                // Vu que TrickCategory est un enum, on ne devrait pas arriver ici. Mais sait-on jamais que l'on rajoute une option plus tard.
                default:
                    Console.WriteLine("{0} regarde le tour de {1}, et il ne sait pas comment réagir !\n", Name, e.MonkeyName);
                    break;
            }
        }
    }
}
