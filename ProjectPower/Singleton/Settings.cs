namespace ProjectPower.Singleton
{

    public class Settings
    {
        private Settings()
        {

        }

        private static Settings _instance;

        private static readonly object _lock = new object();

        public static Settings GetInstance()
        {
            if (_instance == null)
            {

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Settings();
                    }
                }
            }
            return _instance;
        }
    }
}