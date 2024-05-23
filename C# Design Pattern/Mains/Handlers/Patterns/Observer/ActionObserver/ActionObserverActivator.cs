using CDP.Handlers.Programs;

namespace CDP.Handlers.Patterns.ActionObserver
{
    public class ActionObserverActivator : IActivatable
    {
        public void Activate()
        {
            Garage garage = new();

            ActionObservers.OnPayment?.Invoke(15.45f);
            ActionObservers.OnReceiveNewCar?.Invoke("GT-R R35", 3);
        }
    }
}
