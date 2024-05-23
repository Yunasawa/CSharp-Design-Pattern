namespace CDP.Handlers.Patterns.ActionObserver
{
    [System.Serializable]
    public class Garage
    {
        // Add function need to be called by action
        public Garage()
        {
            ActionObservers.OnPayment += Payment;
            ActionObservers.OnReceiveNewCar += ReceiveNewCar;
        }
        // Remove function from action
        ~Garage()
        {
            ActionObservers.OnPayment -= Payment;
            ActionObservers.OnReceiveNewCar -= ReceiveNewCar;
        }

        private void Payment(float price)
        {
            Console.WriteLine($"Paied: {price}");
        }

        private void ReceiveNewCar(string model, int amount)
        {
            Console.WriteLine($"Receive: Model {model} x{amount}");
        }
    }
}