using System;

namespace Patterns.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        static readonly object classLock = new object();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null) 
                {
                    lock (classLock)
                    {
                        if (_instance == null) {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        public int FctA()
        {
            return 1;
        }

        public int FctB()
        {
            return -1;
        }
    }
}
