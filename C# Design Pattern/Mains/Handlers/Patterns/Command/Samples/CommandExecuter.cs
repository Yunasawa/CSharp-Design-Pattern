using CDP.Handlers.Programs;

public partial class PatternType
{
    public const string Command = "Command";
}

namespace CDP.Handlers.Patterns.Command
{
    public class CommandExecuter : IActivatable
    {
        public void Activate()
        {
            Light light = new();
            EnterRoomCommand enterRoomCommand = new(light);
            Human human = new();

            human.SetCommand(enterRoomCommand);
            human.ExecuteCommand();
        }
    }
}
