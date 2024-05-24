namespace CDP.Handlers.Patterns.Command
{
    public class CommandContainer
    {
        private Dictionary<string, Command> _commands = new();

        public void Register(string name, Command command)
        {
            if (_commands.ContainsKey(name)) _commands[name] = command;
            else _commands.Add(name, command);
        }

        public void Execute(string name, object data)
        {
            if (_commands.ContainsKey(name)) _commands[name].Execute(data);
        }
    }
}
