using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonConsoleManager
{
    class ThreadStarter2
    {
        protected int currentNum = 0;
        protected int maxNum;
        protected bool isPaused = true;
        protected Thread printThread;
        protected bool hasEnded = false;

        public ThreadStarter2(int max)
        {
            printThread = new Thread(new ThreadStart(LoopPrint));
            maxNum = max;
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
                    ConsoleManager.GetInstance().WriteLine(currentNum.ToString());
                    currentNum = (currentNum + 1) % maxNum;
                    Thread.Sleep(500);
                }
                else //when paused sleep 5 ms before checking again
                {
                    Thread.Sleep(5);
                }
            }

        }
    }
}
