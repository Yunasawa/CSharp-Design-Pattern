﻿using CDP.Handlers.Patterns.Singleton;

namespace CDP.Handlers.Programs
{
    public class Program
    {
        public Dictionary<string, IActivatable> Activators = new();
        public IActivatable Activator;

        public Program()
        {
            Activators.Add(PatternType.Singleton, new SingletonActivator());
        }

        public void Run(string type)
        {
            Activator = Activators[type];
            Activator.Activate();
        }

        public static void Main(string[] args)
        {
            Program program = new();
            program.Run(PatternType.Singleton);
        }
    }
}
