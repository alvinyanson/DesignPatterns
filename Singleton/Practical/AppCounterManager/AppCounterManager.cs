
using System.Collections.Concurrent;

namespace AppCounterManager
{
    public sealed class AppCounterManager
    {
        private static readonly Lazy<AppCounterManager> _instance = new Lazy<AppCounterManager>(() => new AppCounterManager());

        private static int Counter = 0;

        private ConcurrentDictionary<string, long> counters;


        public AppCounterManager()
        {
            Counter++;
            counters = new ConcurrentDictionary<string, long>();

            Console.WriteLine("Counter Value " + Counter.ToString());
        }

        public void IncrementCounter(string counterName)
        {
            counters.AddOrUpdate(counterName, 1, (key, currentValue) => currentValue + 1);
        }

        public long GetCounterValue(string counterName)
        {
            return counters.TryGetValue(counterName, out var value) ? value : 0;
        }

        public static AppCounterManager Instance => _instance.Value;

    }
}
