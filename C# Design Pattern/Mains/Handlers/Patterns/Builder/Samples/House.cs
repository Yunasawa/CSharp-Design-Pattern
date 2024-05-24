namespace CDP.Handlers.Patterns.Builder
{
    [System.Serializable]
    public class House
    {
        private Dictionary<string, List<string>> _houseRoom = new();

        public House AddRoom(params string[] rooms)
        {
            foreach (var room in rooms) _houseRoom.Add(room, new());
            return this;
        }
        public House AddFurniture(string room, params string[] furnitures)
        {
            if (!_houseRoom.ContainsKey(room)) return this;
            foreach (var furniture in furnitures) _houseRoom[room].Add(furniture);
            return this;
        }

        public void Checkout()
        {
            string houseCheckout = $"There are {_houseRoom.Count} rooms:\n";
            string furnitures = "";

            foreach (var room in _houseRoom)
            {
                foreach (var furniture in room.Value)
                {
                    furnitures += $"{furniture}, ";
                }
                houseCheckout += $"- {room.Key} [{furnitures}]\n";
                furnitures = "";
            }

            Console.WriteLine(houseCheckout);
        }
    }
}
