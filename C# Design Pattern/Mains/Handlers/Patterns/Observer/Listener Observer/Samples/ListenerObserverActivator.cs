using CDP.Handlers.Programs;

public partial class PatternType
{
    public const string ListenerObserver = "ListenerObserver";
}

namespace CDP.Handlers.Patterns.ListenerObserver
{
    public class ListenerObserverActivator : IActivatable
    {
        public void Activate()
        {
            Customer custeomer = new();
        }
    }
}
