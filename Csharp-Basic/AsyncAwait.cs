using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_Basic
{
    public static class AsyncAwait
    {
        public static async Task Start()
        {
            /* Async await are markers which mark code postiions from where control should 
             * resume after a task(thread) completes.
             */
            Console.WriteLine("Starting...");
            await Task.Run(new Action(BackgroundTask));
            Console.WriteLine("Task completed successfully...");

        }

        private static void BackgroundTask()
        {
            Console.WriteLine("Background Task Processing...");
            Thread.Sleep(20000);
        }
    }
}
