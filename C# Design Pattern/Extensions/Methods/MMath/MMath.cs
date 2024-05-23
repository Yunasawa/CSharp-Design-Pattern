namespace CDP.Extensions.Methods
{
    public static class MMath
    {
        public static int RandomNumber(int min, int max)
        {
            Random random = new();
            return random.Next(min, max);
        }
    }
}
