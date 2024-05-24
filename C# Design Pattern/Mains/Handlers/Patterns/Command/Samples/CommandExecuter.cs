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
            CommandContainer container = new();
            container.Register("Enter Room", new EnterRoomCommand());
            container.Register("Buy Food", new BuyFoodCommand());

            container.Execute("Enter Room", 123);
            container.Execute("Buy Food", "Mango");
        }
    }
}
