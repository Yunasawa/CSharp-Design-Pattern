namespace CDP.Handlers.Patterns.Command
{
    public class Light : IReceiver
    {
        public void Action()
        {
            Console.WriteLine("Turn on Light");
        }
    }
}
