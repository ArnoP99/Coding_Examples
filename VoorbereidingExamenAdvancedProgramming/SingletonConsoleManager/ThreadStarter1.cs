using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonConsoleManager
{
    class ThreadStarter1
    {
        protected char currentChar = (char)0;
        protected bool isPaused = true;
        protected Thread printThread;
        protected bool hasEnded = false;

        public ThreadStarter1()
        {
            printThread = new Thread(new ThreadStart(LoopPrint));
        }

        public void Start()
        {
            isPaused = false;
            printThread.Start();
        }
        public void FlipPause()
        {
            isPaused = !isPaused;
        }
        public void Stop()
        {
            hasEnded = true;
            if (printThread.IsAlive)
            {
                printThread.Abort();
            }
        }

        public void LoopPrint()
        {
            while (!hasEnded)
            {
                if (!isPaused)
                {
                    ConsoleManager.GetInstance().WriteLine(((char)(97 + currentChar)).ToString());
                    currentChar = (char)((currentChar + 1) % 26);
                    Thread.Sleep(500);
                }
                else
                {
                    Thread.Sleep(5);
                }
            }

        }
    }
}
