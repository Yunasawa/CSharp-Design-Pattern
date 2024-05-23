using CDP.Extensions.Methods;

namespace CDP.Handlers.Patterns.Singleton
{
    public class Inventory : Singleton<Inventory>
    {
        public List<Slot> Slots = new();

        public override void Initialize()
        {
            for (int i = 0; i < MMath.RandomNumber(10, 20); i++)
            {
                Slots.Add(new(MString.RandomString(10), MMath.RandomNumber(10, 30)));
            }
        }

        public void Checkout()
        {
            foreach (var slot in Slots) Console.WriteLine($"Slot {Slots.IndexOf(slot) + 1}: {slot.ToString()}");
        }
    }
}
