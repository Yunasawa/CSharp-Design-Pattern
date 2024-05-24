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
                .AddRoom("Living Room").AddFurniture("Living Room", "TV", "Sofa", "Clock")
                .AddRoom("Kitchen").AddFurniture("Kitchen", "Sink", "Fridge", "Oven")
                .AddRoom("Bath Room").AddFurniture("Bath Room", "Bath", "Sink", "Mirror", "Toilet", "Tower");

            house.Checkout();
        }
    }
}
