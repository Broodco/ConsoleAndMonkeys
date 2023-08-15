using ConsoleAndMonkeys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAndMonkeys.Models
{
    internal class Monkey : IMonkey
    {
        public string Name { get; set; }
        public List<ITrick> Tricks { get; set; }

        public Monkey(string name, List<ITrick> tricks)
        {
            Name= name;
            Tricks = tricks;
        }

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
        }

        // Effectuer un trick -> dispatch un event + call trick execute
        private void DoTrick(ITrick trick)
        {
            Console.WriteLine("{0} est entrain de faire une tour. Il fait le tour {1}, qui est un(e) {2} !", Name, trick.Name, trick.Category);
        }
    }
}
