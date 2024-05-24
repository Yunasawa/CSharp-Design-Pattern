using CDP.Handlers.Programs;

public partial class PatternType
{
    public const string Singleton = "Singleton";
}


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
