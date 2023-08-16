using ConsoleAndMonkeys.Interfaces;

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
