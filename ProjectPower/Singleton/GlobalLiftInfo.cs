
namespace ProjectPower.Singleton
{
    // This Singleton implementation is called "double check lock". It is safe
    // in multithreaded environment and provides lazy initialization for the
    // Singleton object.
    public class GlobalLiftInfo
    {
        private GlobalLiftInfo() { }

        private static GlobalLiftInfo _instance;

        // We now have a lock object that will be used to synchronize threads
        // during first access to the Singleton.
        private static readonly object _lock = new object();

        public static GlobalLiftInfo GetInstance()
        {
            // This conditional is needed to prevent threads stumbling over the
            // lock once the instance is ready.
            if (_instance == null)
            {
                // Now, imagine that the program has just been launched. Since
                // there's no Singleton instance yet, multiple threads can
                // simultaneously pass the previous conditional and reach this
                // point almost at the same time. The first of them will acquire
                // lock and will proceed further, while the rest will wait here.
                lock (_lock)
                {
                    // The first thread to acquire the lock, reaches this
                    // conditional, goes inside and creates the Singleton
                    // instance. Once it leaves the lock block, a thread that
                    // might have been waiting for the lock release may then
                    // enter this section. But since the Singleton field is
                    // already initialized, the thread won't create a new
                    // object.
                    if (_instance == null)
                    {
                        _instance = new GlobalLiftInfo();
                    }
                }
            }
            return _instance;
        }

        // We'll use this property to prove that our Singleton really works.
        public static decimal SquatTrainingMax = 125;
        public static decimal BenchTrainingMax { get; set; }
        public static decimal OhpTrainingMax { get; set; }
        public static decimal DeadliftTrainingMax { get; set; }
      
        public static int WeekOneTierOneRepsPerSet = 6;

        public static readonly decimal w1T1 = 0.7M;

    }
}