namespace ConsoleAndMonkeys.Interfaces
{
    internal interface ISpectator
    {
        string Name { get; }
        void StartWatchingMonkeyDoingTricks(IMonkey monkey);
    }
}
