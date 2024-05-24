using CDP.Handlers.Patterns.ActionObserver;
using CDP.Handlers.Patterns.Builder;
using CDP.Handlers.Patterns.Command;
using CDP.Handlers.Patterns.ListenerObserver;
using CDP.Handlers.Patterns.Singleton;

namespace CDP.Handlers.Programs
{
    public class Program
    {
        public Dictionary<string, IActivatable> Activators = new();
        public IActivatable Activator;

        public Program()
        {
            Activators.Add(PatternType.Singleton, new SingletonActivator());
            Activators.Add(PatternType.ActionObserver, new ActionObserverActivator());
            Activators.Add(PatternType.ListenerObserver, new ListenerObserverActivator());
            Activators.Add(PatternType.Builder, new BuilderActivator());
            Activators.Add(PatternType.Command, new CommandExecuter());
        }
        
        public void Run(string type)
        {
            Activator = Activators[type];
            Activator.Activate();
        }

        public static void Main(string[] args)
        {
            Program program = new();
            program.Run(PatternType.Command);
        }
    }
}
