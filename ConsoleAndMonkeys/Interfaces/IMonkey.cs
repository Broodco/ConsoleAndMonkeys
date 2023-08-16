using ConsoleAndMonkeys.Events;

namespace ConsoleAndMonkeys.Interfaces
{
    internal interface IMonkey
    {
        string Name { get; set; }
        List<ITrick> Tricks { get; set; }
        event EventHandler<TrickExecutionEvent>? RaiseTrickExecutionEvent;

        void DoAllTricks();
    }
}
