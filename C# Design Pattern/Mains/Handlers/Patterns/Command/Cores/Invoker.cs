namespace CDP.Handlers.Patterns.Command
{
    public abstract class Invoker
    {
        protected Command _command;

        public void SetCommand(Command command) => _command = command;

        public void ExecuteCommand() => _command.Execute();
    }
}
