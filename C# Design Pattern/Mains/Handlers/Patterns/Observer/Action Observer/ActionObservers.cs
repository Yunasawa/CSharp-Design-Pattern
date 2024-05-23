public partial class PatternType
{
    public const string ActionObserver = "ActionObserver";
}

namespace CDP.Handlers.Patterns.ActionObserver
{
    public static class ActionObservers
    {
        public static Action<float> OnPayment;
        public static Action<string, int> OnReceiveNewCar;
    }
}
