using CDP.Handlers.Programs;

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
