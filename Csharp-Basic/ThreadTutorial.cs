using System;
using System.Threading;

namespace Csharp_Basic
{
    /* c# Threading
     *  Basics of threading
     *  Thread safety, locks and monitor
     *  Mutex/ semaphore and semaphore slim - thread safety outproc
     *  Debug Threading
     */
    public static class ThreadTutorial
    {
        public static void Start()
        {
            var threadSafety = new ThreadSafety();
            var thread1 = new Thread(new ThreadStart(threadSafety.TestMethod));
            thread1.Start();

            threadSafety.TestMethod();

            Console.WriteLine("Demo completed");
        }
        public static void StartMutex()
        {
            /* Mutex is a synchronization primitive that can also be used for interprocess synchronization
             * does lock but from outside proc, exe or dll to prevent from starting new instance of application
             * semaphore and semaphore slim is des very same thing to mutex but we can configure how many instance of application we requires.
             * */

            using (var m1 = new Mutex(false, "instanceone"))
            {
                if (!m1.WaitOne(5000, false))
                {
                    Console.WriteLine("other instance is already running, exiting...");
                    return;
                }

                Console.WriteLine("Application started...");
            }
        }
    }

    public class ThreadSafety
    {
        private int num1 = 0;
        private int num2 = 0;
        private int num3 = 0;

        public void TestMethod()
        {
            for (int i = 1; i < 1000000; i++)
            {
                lock (this) // syntatic sugar over monitor
                {
                    num1 = 1; num2 = 1;
                    num3 = num1 / num2; // thread unsafe
                    num1 = 0;
                    num2 = 0;
                }

                //Monitor.Enter(this);
                //num1 = 1; num2 = 1;
                //num3 = num1 / num2; // thread unsafe
                //num1 = 0;
                //num2 = 0;
                //Monitor.Exit(this);
            }
            Console.WriteLine("Execution comleted");
        }
    }
}