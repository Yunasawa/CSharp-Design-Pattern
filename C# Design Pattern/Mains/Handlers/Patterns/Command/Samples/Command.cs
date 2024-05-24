namespace CDP.Handlers.Patterns.Command
{
    public abstract class Command
    {
        public object Data;

        public abstract void Execute(object data);
    }
}
