using ConsoleAndMonkeys.Events;
using ConsoleAndMonkeys.Interfaces;

namespace ConsoleAndMonkeys.Models
{
    internal class Monkey : IMonkey
    {
        public string Name { get; set; }
        public List<ITrick> Tricks { get; set; }
        public event EventHandler<TrickExecutionEvent>? RaiseTrickExecutionEvent;

        public Monkey(string name, List<ITrick> tricks)
        {
            Name= name;
            Tricks = tricks;
        }

        // Méthode permettant au singe d'effectuer tous ses tours. Il peut le faire de soi-même ou via le handler.
        public void DoAllTricks()
        {
            if (Tricks.Count == 0)
            {
                Console.WriteLine("{0} ne connait pas de tour.", Name);
                return;
            }
            foreach(ITrick trick in Tricks)
            {
                DoTrick(trick);
            }
            Console.WriteLine("{0} a fini ses tours.\n", Name);
        }

        private void DoTrick(ITrick trick)
        {
            string trickType = trick.Category == TrickCategory.Acrobatie ? "une acrobatie" : "un tour de musique";
            Console.WriteLine("{0} est entrain de faire un tour. Il fait le tour '{1}', qui est {2} !", Name, trick.Name, trickType);
            RaiseTrickExecutionEvent?.Invoke(this, new TrickExecutionEvent(trick, Name));
        }
    }
}
