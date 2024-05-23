namespace CDP.Handlers.Patterns.ActionObserver
{
    [System.Serializable]
    public class Garage
    {
        public Garage()
        {
            ActionObservers.OnPayment += Payment;
            ActionObservers.OnReceiveNewCar += ReceiveNewCar;
        }

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