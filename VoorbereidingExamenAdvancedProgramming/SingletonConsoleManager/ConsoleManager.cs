using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonConsoleManager
{
    class ConsoleManager
    {

        private static readonly Object consoleLock = new Object();
        private static ConsoleManager instance;

        private ConsoleManager()
        {
        }

        public static ConsoleManager GetInstance()
        {
            if (instance == null)
            {
                lock (consoleLock)
                {
                    if (instance == null)
                    {
                        instance = new ConsoleManager();
                    }
                }
            }
            return instance;
        }

        public void WriteLine(string s)
        {
            lock (consoleLock)
            {
                Console.WriteLine(s);
            }
        }


    }
}
