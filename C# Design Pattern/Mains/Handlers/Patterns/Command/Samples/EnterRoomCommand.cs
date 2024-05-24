﻿namespace CDP.Handlers.Patterns.Command
{
    public class EnterRoomCommand : Command
    {
        public override void Execute(object data)
        {
            Console.WriteLine($"Enter room number: {data}");
        }
    }
}
