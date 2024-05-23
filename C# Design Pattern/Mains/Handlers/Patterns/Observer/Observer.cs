namespace CDP.Handlers.Patterns.Observer
{
    public partial class PatternType
    {
        public const string Observer = "Observer";
    }

    public class Observer
    {
        private void Notification()
        {
            ObserverAction.CallObserver += Started;
        }

        private void StopNotification()
        {
            ObserverAction.CallObserver -= Started;
        }

        public void Started() { }
    }
}
