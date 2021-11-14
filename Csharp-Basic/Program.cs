using System;

namespace Csharp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //AsyncAwait.Start();
            //Concurrent_Parallelism.ParallelOrchestration();
            //Concurrent_Parallelism.ConcurrentOrchestration();
            //Async_Thread.AsyncOrchestration();
            ThreadTutorial.StartMutex();

            Console.WriteLine("Enter any key to exit: ");
            Console.ReadLine();
        }
    }
}
