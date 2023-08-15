using ConsoleAndMonkeys.Interfaces;

namespace ConsoleAndMonkeys.Events
{
    internal class TrickExecutionEvent : EventArgs
    {
        public ITrick Trick { get; set; }
        public string MonkeyName { get; set; }

        public TrickExecutionEvent(ITrick trick, string monkeyName)
        {
            Trick = trick;
            MonkeyName = monkeyName;
        }
    }
}
