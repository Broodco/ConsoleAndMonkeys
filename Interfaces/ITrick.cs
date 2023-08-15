namespace ConsoleAndMonkeys.Interfaces
{
    internal interface ITrick
    {
        string Name { get; set; }
        TrickCategory Category { get; set; }
    }

    enum TrickCategory
    {
        Musique,
        Acrobatie
    }
}
