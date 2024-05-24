namespace CDP.Handlers.Patterns.Command
{
    public class BuyFoodCommand : Command
    {
        public override void Execute(object data)
        {
            Console.WriteLine($"Buy some food: {data}");
        }
    }
}
