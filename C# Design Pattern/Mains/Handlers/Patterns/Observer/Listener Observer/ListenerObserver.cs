public partial class PatternType
{
    public const string ListenerObserver = "ListenerObserver";
}

namespace CDP.Handlers.Patterns.ListenerObserver
{
    public class ListenerObserver
    {
        private static Dictionary<Type, IListenerBase> _singleSubscribers = new();
        private static Dictionary<Type, List<IListenerBase>> _multipleSubscribers = new();

        #region Single Listener
        public static void AddSingle<E>(IListener<E> listener) where E : struct
        {
            Type eventType = typeof(E);
            if (!_singleSubscribers.ContainsKey(eventType)) _singleSubscribers[eventType] = listener;
        }

        public static void RemoveSingle<E>(IListener<E> listener) where E : struct
        {
            Type eventType = typeof(E);

            if (!_singleSubscribers.ContainsKey(eventType)) return;
            _singleSubscribers.Remove(eventType);
        }

        public static void TriggerSingle<E>(E newEvent) where E : struct
        {
            if (!_singleSubscribers.TryGetValue(typeof(E), out IListenerBase listeners)) return;

            (listeners as IListener<E>).Invoke(newEvent);
        }
        #endregion

        #region Multiple Listeners
        public static void AddMultiple<E>(IListener<E> listener) where E : struct
        {
            Type eventType = typeof(E);
            if (!_multipleSubscribers.ContainsKey(eventType)) _multipleSubscribers[eventType] = new();
            _multipleSubscribers[eventType].Add(listener);
        }

        public static void RemoveMultiple<E>(IListener<E> listener) where E : struct
        {
            Type eventType = typeof(E);

            if (!_multipleSubscribers.ContainsKey(eventType)) return;
            _multipleSubscribers.Remove(eventType);
        }

        public static void TriggerMultiple<E>(E newEvent) where E : struct
        {
            if (!_multipleSubscribers.TryGetValue(typeof(E), out List<IListenerBase> listeners)) return;

            for (int i = 0; i < listeners.Count; i++) (listeners[i] as IListener<E>).Invoke(newEvent);
        }
        #endregion
    }

    public static class ObserverRegister
    {
        public static void RegisterSingle<E>(this IListener<E> caller) where E : struct => ListenerObserver.AddSingle<E>(caller);
        public static void UnregisterSingle<E>(this IListener<E> caller) where E : struct => ListenerObserver.RemoveSingle<E>(caller);

        public static void RegisterMultiple<E>(this IListener<E> caller) where E : struct => ListenerObserver.AddMultiple<E>(caller);
        public static void UnregisterMultiple<E>(this IListener<E> caller) where E : struct => ListenerObserver.RemoveMultiple<E>(caller);
    }

    public interface IListenerBase { };
    public interface IListener<E> : IListenerBase
    {
        void Invoke(E @event);
    }
}
