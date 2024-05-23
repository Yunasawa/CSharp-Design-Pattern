namespace CDP.Handlers.Patterns.Singleton
{
    [System.Serializable]
    public class Slot
    {
        public string Item { get; set; }
        public int Amount { get; set; }

        public Slot(string item, int amount)
        {
            Item = item;
            Amount = amount;
        }

        public override string ToString() => $"{Item} x{Amount}";
    }
}
