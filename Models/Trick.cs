using ConsoleAndMonkeys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAndMonkeys.Models
{
    internal class Trick : ITrick
    {
        public TrickCategory Category { get; set; }
        public string Name { get; set; }

        public Trick(TrickCategory category, string name)
        {
            Category = category;
            Name = name;
        }
    }

}
