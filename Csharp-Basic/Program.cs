using System;

namespace Csharp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //AsyncAwait.Start();
            //ConcurrentParallelism.ParallelOrchestration();
            ConcurrentParallelism.ConcurrentOrchestration();

            Console.WriteLine("Enter any key to exit: ");
            Console.ReadLine();
        }
    }
}
