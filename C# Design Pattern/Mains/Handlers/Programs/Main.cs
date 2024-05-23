using CDP.Handlers.Patterns.Singleton;
using System.Runtime.Serialization.Formatters.Binary;

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
        
        public void Started()
        {
            ObserverAction.CallObserver?.Invoke();
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
