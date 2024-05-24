namespace CDP.Handlers.Patterns.Command
{
    public abstract class Command
    {
        protected IReceiver _receiver;

        public Command(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public abstract void Execute();
    }
}
