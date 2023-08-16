using ConsoleAndMonkeys.Interfaces;

namespace ConsoleAndMonkeys.Models
{
    internal class Handler : IHandler
    {
        private string Name { get; set; }
        private List<IMonkey> Monkeys { get; set; }

        public Handler(string name)
        {
            Name = name;
            Monkeys = new List<IMonkey>();
        }

        public void AddMonkey(IMonkey monkey) 
        {
            Monkeys.Add(monkey);
        }

        public void OrderMonkeysToDoTricks()
        {
            Console.WriteLine("{0} demande a ses singes d'exécuter leurs tours.\n", Name);

            if (Monkeys.Count == 0)
            {
                Console.WriteLine("{0} n'a pas de singe.", Name);
                return;
            } 

            foreach (IMonkey monkey in Monkeys)
            {
                monkey.DoAllTricks();
            }
        }
    }
}
