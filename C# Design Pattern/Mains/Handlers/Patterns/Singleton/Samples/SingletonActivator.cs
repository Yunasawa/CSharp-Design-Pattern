using CDP.Handlers.Programs;

namespace CDP.Handlers.Patterns.Singleton
{
    public class SingletonActivator : IActivatable
    {
        public void Activate()
        {
            Inventory.Instance.Checkout();
        }
    }
}
