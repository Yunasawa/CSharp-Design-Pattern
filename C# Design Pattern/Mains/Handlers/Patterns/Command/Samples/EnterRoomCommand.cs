namespace CDP.Handlers.Patterns.Command
{
    public class EnterRoomCommand : Command
    {
        public EnterRoomCommand(IReceiver receiver) : base(receiver) { }

        public override void Execute()
        {
            _receiver.Action();
        }
    }
}
