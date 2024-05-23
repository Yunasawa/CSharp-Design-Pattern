namespace CDP.Handlers.Patterns.ListenerObserver
{
    [System.Serializable]
    public class Customer
    {
        public Customer()
        {
            Waiter waiter = new();

            Dish.Invoke(10, "Omelette", 2);
        }
    }
}
