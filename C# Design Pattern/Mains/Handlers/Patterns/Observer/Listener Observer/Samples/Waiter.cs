namespace CDP.Handlers.Patterns.ListenerObserver
{
    [System.Serializable]
    public class Waiter : IListener<Dish>
    {
        public Waiter() { this.RegisterMultiple(); }
        ~Waiter() { this.UnregisterMultiple(); }

        public void Invoke(Dish dish)
        {
            Console.WriteLine($"Table {dish.Table} called {dish.Name} x{dish.Amount}");
        }
    }

    [System.Serializable]
    public struct Dish
    {
        public int Table;
        public string Name;
        public int Amount;

        public static Dish E;

        public static void Invoke(int table, string name, int amount)
        {
            Dish.E.Table = table;
            Dish.E.Name = name;
            Dish.E.Amount = amount;
            ListenerObserver.TriggerMultiple(E);
        }
    }
}