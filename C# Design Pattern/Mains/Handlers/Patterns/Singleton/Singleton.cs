public partial class PatternType
{
    public const string Singleton = "Singleton";
}

namespace CDP.Handlers.Patterns
{
    public class Singleton<T> where T : Singleton<T>
    {
        // Static field for singleton instance
        private static T _instance;

        // Static property for singleton instance
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    // If singleton is null, create a new instance for it
                    _instance = Activator.CreateInstance<T>();
                    _instance.Initialize(); // Initialize singleton for the first time created
                }
                return _instance;
            }
        }

        // Do initializations here
        public virtual void Initialize() { }
    }
}
