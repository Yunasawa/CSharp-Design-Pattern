using CDP.Handlers.Programs;

public partial class PatternType
{
    public const string Builder = "Builder";
}

namespace CDP.Handlers.Patterns.Builder
{
    public class BuilderActivator : IActivatable
    {
        public void Activate()
        {
            House house = new();

            house
                .AddRoom("Living Room", "Kitchen", "Bath Room")
                .AddFurniture("Living Room", "TV", "Sofa", "Clock")
                .AddFurniture("Kitchen", "Sink", "Fridge", "Oven", "Baker")
                .AddFurniture("Bath Room", "Bath", "Sink", "Mirror", "Toilet", "Tower");

            house.Checkout();
        }
    }
}
